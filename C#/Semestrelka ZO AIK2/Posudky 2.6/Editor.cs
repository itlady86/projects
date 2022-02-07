
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Posudky
{
    /// <summary>
    /// Description of Editor.
    /// </summary>
    public partial class Editor : Form
    {
        private Databaze db = new Databaze();
        private string passCislo;
        private int index;
        private string stopa;
        private string nazev;
        private int id;

        //předávání parametrů mezi jednotlivými Formy
        public Editor(string CisloPosudku, int index)
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = CisloPosudku;
            passCislo = CisloPosudku.Substring(12);
            this.index = index;
        }

        public Editor()
        {
            InitializeComponent();
        }

        public Editor(string nazev)
        {
            this.nazev = nazev;
        }


        private void Editor_Load(object sender, EventArgs e)
        {
            ImageList();
            var ui = db.LoadJson();
            foreach (var v in ui)
            {
                if (v.Posudek.CisloP == passCislo)
                {
                    //ověření, že je v category a item už nějaký záznam
                    // zobrazení příslušné ikonky + názvu stopy v listView
                    if (v.Posudek.Category != null && v.Posudek.Item != null)
                    {
                        for (int i = 0; i < v.Posudek.Category.Count; i++)
                        {
                            for (int j = 0; j < v.Posudek.Item.Count; j++)
                            {
                                if (i == j)
                                {
                                    switch (v.Posudek.Category[i].Stopa)
                                    {
                                        case "počítač":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 0); break;
                                        case "pevný disk":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 1); break;
                                        case "flash disk":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 2); break;
                                        case "paměťová karta":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 3); break;
                                        case "fotoaparát":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 4); break;
                                        case "bitová kopie":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 5); break;
                                        case "herní konzole":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 6); break;
                                        case "mobilní telefon":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 7); break;
                                        case "tablet":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 8); break;
                                        case "GPS navigace":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 9); break;
                                        case "DVR zařízení":
                                            lv.Items.Add(v.Posudek.Item[j].Nazev, 10); break;
                                    }
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
            }
        }


        //Smazat stopu
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //počet vybraných items
            //var s = lv.SelectedItems;
            //System.Diagnostics.Debug.WriteLine(s.Count.ToString());

            int index = 0;
            if (lv.SelectedItems.Count > 0)
            {
                index = lv.Items.IndexOf(lv.SelectedItems[0]);
                System.Diagnostics.Debug.WriteLine(index);
            }

            if (MessageBox.Show("Opravdu smazat vybranou stopu?", "Akce", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lv.Items.RemoveAt(index);
                System.Diagnostics.Debug.WriteLine("Smazáno z listView");
            }

            //smazat z json
            var ui = db.LoadJson();

            //vyhledá příslušný poosudek podle čísla
            for (int i = 0; i < ui.Count; i++)
            {
                if (ui[i].Posudek.CisloP == passCislo)
                    id = i;
            }

            ui[id].Posudek.Category.RemoveAt(index);
            ui[id].Posudek.Item.RemoveAt(index);

            //zápis do json
            string JsonInput = JsonConvert.SerializeObject(ui, Formatting.Indented);
            File.WriteAllText(db.fileName, JsonInput);
            System.Diagnostics.Debug.WriteLine("Smazáno z Json");

        }

        //Refresh
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lv.Clear();
            Editor_Load(sender, e);
        }


        //Návrat zpět
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ToolStripMenuItemPC_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemHD_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemFlash_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemMC_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemCam_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemDD_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemPS_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemMT_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemTab_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemGPS_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        private void ToolStripMenuItemDVR_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            stopa = ts.Text;

            Form NewItem = new NewItem(stopa, passCislo);
            NewItem.Show();
        }

        // načtení ikonek do ImageListu
        private void ImageList()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            string[] icons = { };
            icons = Directory.GetFiles(@"..\..\icons\ImageList\");

            try
            {
                foreach (string icon in icons)
                {
                    imgs.Images.Add(Image.FromFile(icon));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lv.LargeImageList = imgs;

        }

        private void lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form Tasks = new Tasks(passCislo, id);
            Tasks.Show();
        }
    }

}

