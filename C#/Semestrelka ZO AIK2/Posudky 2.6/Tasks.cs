using Newtonsoft.Json;
using System;

using System.Windows.Forms;

namespace Posudky
{
    public partial class Tasks : Form
    {
        Databaze db = new Databaze();
        private string passCislo;
        private int id;


        public Tasks(string passCislo, int id)
        {
            InitializeComponent();
            this.passCislo = passCislo;
            this.id = id;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TODO:
        private void buttonNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wait for it ...... ");

            //var ui = db.LoadJson();
            ////uložení do json
            //ui[id].Posudek.Category = new List<Category>() { new Category(stopa) };

            //ui[id].Posudek.Item = new List<Item>() { new Item(nazev) };

            //string JsonInput = JsonConvert.SerializeObject(ui, Formatting.Indented);
            //File.WriteAllText(db.fileName, JsonInput);
            //System.Diagnostics.Debug.Print("Uloženo poprvé");



            this.Close();
        }
    }
}
