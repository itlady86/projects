
using System;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace Posudky
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Databaze db = new Databaze();
		DataTable dt = new DataTable();
		public int index;
		public string CisloPosudku;

		public MainForm()
		{
			Thread t = new Thread(new ThreadStart(StartForm));
			t.Start();
			Thread.Sleep(5000);

			InitializeComponent();
			StatusLabel.Text = "Posudek č.: 1/2021";

			t.Abort();
		}

		//Splash Screen
		public void StartForm()
		{
			Application.Run(new Splash());
		}


		private void MainForm_Load(object sender, EventArgs e)
		{
			CreateHeader();
			dgv1.RefreshEdit();
			FillData();
		}

		//naplnění hlavičky datagridView 
		private void CreateHeader()
		{
			dt.Columns.Add("CISLO POSUDKU", Type.GetType("System.String"));
			dt.Columns.Add("SPECIFIKACE", Type.GetType("System.String"));
			dt.Columns.Add("OBVINĚNÝ", Type.GetType("System.String"));
			dt.Columns.Add("ČTS", Type.GetType("System.String"));
			dt.Columns.Add("OPATŘENÍ ZE DNE", Type.GetType("System.String"));
			dgv1.DataSource = dt;

			//výška řádku
			dgv1.RowTemplate.MinimumHeight = 47;

			// sloupce nejsou sortovatelné
			foreach (DataGridViewColumn dgvc in dgv1.Columns)
			{
				dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		// naplnění datagridView daty z JSON databáze
		private void FillData()
		{
			var output = db.LoadJson();
			foreach (var v in output)
			{
				dt.Rows.Add(v.Posudek.CisloP, v.Posudek.Information.Specifikace, v.Posudek.Information.Jmeno, v.Posudek.Information.CTS, v.Posudek.Information.DatumOpatreni);
			}
		}

		//po kliknutí na řádek v datagridView --> zobrazení čísla posudku ve status liště
		private void dgv1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				CisloPosudku = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
				StatusLabel.Text = "Posudek č.: " + CisloPosudku;
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.Print(ex.ToString());
			}
		}

		// tlačítko Založit posudek
		private void BtnNew_Click(object sender, EventArgs e)
		{
			bool inputIsCorrect = false;
			string[] txtBox = new string[5] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text };

			for (int i = 0; i < txtBox.Length; i++)
			{
				if (txtBox[i] == "")
				{
					MessageBox.Show("Vyplň potřebné informace ! ");
					inputIsCorrect = false;
					break;
				}
				else
				{
					inputIsCorrect = true;
					break;
				}
			}

			//TODO: ošetření duplicitně vložených čísel posudků

			if (inputIsCorrect)
			{
				DGVRefresh();
				SaveJson();
				textBox1.Text = "";
				textBox2.Text = "";
				textBox3.Text = "";
				textBox4.Text = "";
			}
		}


		// zápis nových dat do datagridView		
		private void DGVRefresh()
		{
			dt.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text);
			System.Diagnostics.Debug.Print("Zapsáno");
		}


		//zápis do json
		private void SaveJson()
		{
			var ui = db.LoadJson();
			ui.Add(new Root
			{
				Posudek = new Posudek
				{
					CisloP = textBox1.Text,
					Information = new Information
					{
						Specifikace = textBox2.Text,
						Jmeno = textBox3.Text,
						CTS = textBox4.Text,
						DatumOpatreni = dateTimePicker1.Text
					}
				}
			});

			string JsonInput = JsonConvert.SerializeObject(ui, Formatting.Indented);
			File.WriteAllText(db.fileName, JsonInput);
			System.Diagnostics.Debug.Print("Uloženo");
		}

		//tlačítko Přejít k posudku
		private void BtnEdit_Click(object sender, EventArgs e)
		{
			string cislo = StatusLabel.Text;
			Form Editor = new Editor(cislo, index);
			Editor.Show();
		}

		//tlačítko Smazat posudek
		private void BtnDel_Click(object sender, EventArgs e)
		{
			//smazat z dgv
			index = dgv1.CurrentRow.Index;
			if (index == -1)
			{
				return;
			}
			else if (MessageBox.Show("Opravdu smazat vybraný posudek?", "Akce", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				dt.Rows.RemoveAt(index);

			//smazat z json a uložit
			var ui = db.LoadJson();
			ui.RemoveAt(index);

			string JsonInput = JsonConvert.SerializeObject(ui, Formatting.Indented);
			File.WriteAllText(db.fileName, JsonInput);
		}

		// O programu
		private void BtnAbout_Click(object sender, EventArgs e)
		{
			Form About = new About();
			About.Show();
		}

	}
}
