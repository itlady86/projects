using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Posudky
{
    public partial class NewItem : Form
    {
        Databaze db = new Databaze();
        public string passCislo;
        public string stopa;
        public string nazev;
        public int id;


        public NewItem(string stopa, string passCislo)
        {
            InitializeComponent();
            this.stopa = stopa;
            this.passCislo = passCislo;
        }

        //??
        private void textBox1_Validated(object sender, EventArgs e)
        {
            this.ActiveControl = buttonCreate;
        }

        //Tlačítko Vytvořit
        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            var ui = db.LoadJson();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Je třeba vyplnit název stopy !", "Chyba");
            }
            else
            {
                nazev = textBox1.Text;

                // zjištění indexu podle čísla posudku
                for (int i = 0; i < ui.Count; i++)
                {
                    if (ui[i].Posudek.CisloP == passCislo)
                        id = i;
                }
                //první záznam
                if (ui[id].Posudek.Category == null)
                {
                    //uložení do json
                    ui[id].Posudek.Category = new List<Category>() { new Category(stopa) };
                    ui[id].Posudek.Item = new List<Item>() { new Item(nazev) };
                    string JsonInput = JsonConvert.SerializeObject(ui, Formatting.Indented);
                    File.WriteAllText(db.fileName, JsonInput);
                    System.Diagnostics.Debug.Print("Uloženo poprvé");

                    this.Close();

                    //další záznam
                }
                else
                {
                    System.Diagnostics.Debug.Print("Další záznam");
                    ui[id].Posudek.Category.Add(new Category(stopa));
                    ui[id].Posudek.Item.Add(new Item(nazev));
                    string JsonInput = JsonConvert.SerializeObject(ui, Formatting.Indented);
                    File.WriteAllText(db.fileName, JsonInput);
                    System.Diagnostics.Debug.Print("Uloženo znovu");
                    this.Close();
                }
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
