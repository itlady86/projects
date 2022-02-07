
using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Xml.Linq;


namespace PhoneBook
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{		
		public DataHandler DH = new DataHandler();
		
		public MainForm()
		{
			InitializeComponent();
			DH.LoadCSV(DataHandler.filename);
			FillListbox();
		}
					
							
		public void BtnAddContactClick(object sender, EventArgs e) 
		{
			bool Entry = tbFirstName.Text != "" && tbLastName.Text != "" && tbPhoneNumber.Text != ""
				&& tbEmail.Text != "" && tbDepartment.Text != "" && tbPhoneNumber.Text.All(char.IsDigit);
			
			if (Entry) {				// hodnoty jednotlivých inputů
				DH.SaveCSV();
				ClearTextBox();
				listBox.Items.Clear();
				DH.records.Clear();
				DH.LoadCSV(DataHandler.filename);
				FillListbox();				
			} else	{	// vstup od uživatele není OK
				// v inputu Telefon musí být jen čísla bez mezer
				if (!tbPhoneNumber.Text.All(char.IsDigit) || tbPhoneNumber.Text.Contains(" ")) {
					MessageBox.Show("Pole Telefon musí obsahovat pouze čísla bez mezer.");
				} else if (!Entry) {	// nejsou vyplněna všechna pole inputů
					MessageBox.Show("Je třeba vyplnit všechna pole.");
				}
			}
		}
				
		
		public void BtnDelContactClick(object sender, EventArgs e) 
		{
			if (listBox.SelectedIndex == -1) {
				return;
			} else if (MessageBox.Show("Opravdu smazat?", "Akce", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				DH.records.RemoveAt(listBox.SelectedIndex);
				listBox.Items.RemoveAt(listBox.SelectedIndex);
		}
		
		
		public void ButtonExitClick(object sender, EventArgs e)
		{
			File.WriteAllLines(DataHandler.filename, DH.records.Select(x => string.Join(";", x)));
			this.Close();
		}
		
		
		public void BtnSaveXmlClick(object sender, EventArgs e)
		{
			string xml = "";
			string[] source = File.ReadAllLines(DataHandler.filename);
			XElement export = new XElement("Root",
				from str in source
				let fields = str.Split(';')
				select new XElement("Record", 
                    new XElement ("FirstName", fields[1]),
                    new XElement ("LastName", fields[0]),
                    new XElement ("PhoneNumber", fields[2]),
                    new XElement ("Email", fields[3]),
                    new XElement ("Department", fields[4])
                   )
				);
			File.WriteAllText("export.xml", xml + export.ToString());
			MessageBox.Show("Soubor 'export.xml' byl uložen do složky 'bin/debug'.");
		}
		
						
		
		/// <summary>
		/// naplní listbox daty z CSV, hodnoty oddělené pomlčkou
		/// </summary>
		public void FillListbox() 
		{
			for (int i = 0; i < DH.records.Count; i++) {
				listBox.Items.Add(DH.records[i].DataToString());
			}
		}
		
						
		/// <summary>
		/// vymaže textBoxy
		/// </summary>
		public void ClearTextBox()
		{
			tbFirstName.Clear();
			tbLastName.Clear();
			tbPhoneNumber.Clear();
			tbEmail.Clear();
			tbDepartment.Clear();
		}
				
		
	}
}

