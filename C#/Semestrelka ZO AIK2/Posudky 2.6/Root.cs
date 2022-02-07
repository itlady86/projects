using System;
using System.Collections.Generic;


namespace Posudky
{
    public class Root
    {
        public Posudek Posudek { get; set; }

        public Root()
        {
        }

        public Root(Posudek posudek)
        {
        }
    }

    public class Posudek
    {
        public string CisloP { get; set; }
        public Information Information { get; set; }
        public List<Category> Category { get; set; }
        public List<Item> Item { get; set; }

        public Posudek()
        {
        }

        public Posudek(string cisloP, Information information)
        {
            this.CisloP = cisloP;
            this.Information = information;
        }
    }

    public class Information
    {
        public string Specifikace { get; set; }
        public string Jmeno { get; set; }
        public string CTS { get; set; }
        public string DatumOpatreni { get; set; }

        public Information()
        {
        }

        public Information(string specifikace, string jmeno, string cts, string datumOpatreni)
        {
            this.Specifikace = specifikace;
            this.Jmeno = jmeno;
            this.CTS = cts;
            this.DatumOpatreni = datumOpatreni;
        }
    }

    public class Category
    {
        public string Stopa { get; set; }

        public Category()
        {
        }

        public Category(string stopa)
        {
            this.Stopa = stopa;
        }
    }

    public class Item
    {
        public string Nazev { get; set; }
        public Data Data { get; set; }

        public Item()
        {
        }

        public Item(string nazev)
        {
            this.Nazev = nazev;
        }

    }

    public class Data
    {
        public string sit { get; set; }
        public string typDisku { get; set; }
        public string zajisteni { get; set; }
        public string prislusenstvi { get; set; }
        public string pocetDisku { get; set; }
        public string hw { get; set; }
        public string OS { get; set; }
        public string poskozeni { get; set; }
        public string ucet { get; set; }
        public string time { get; set; }
        public string pocetPartition { get; set; }
    }
}


