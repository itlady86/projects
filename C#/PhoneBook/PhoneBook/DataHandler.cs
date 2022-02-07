using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using System.Windows.Forms;

namespace PhoneBook
{
	/// <summary>
	/// Description of DataHandler.
	/// </summary>
	public class DataHandler
	{
		public List<Record> records = new List<Record>();
		public const string filename = "data-no.csv";
			
	
		public DataHandler()
		{
		}
			
		
		/// <summary>
		/// načítá data z CSV
		/// </summary>
		/// <param name="filename">název CSV souboru</param>
		public void LoadCSV(string filename) 
		{
			string radky;
			using (StreamReader sr = new StreamReader(filename, Encoding.UTF8)) {
				while ((radky = sr.ReadLine()) != null) {
					string[] sloupce = radky.Split(';');
					records.Add(new Record(sloupce[0], sloupce[1], Int32.Parse(sloupce[2]), sloupce[3], sloupce[4]));
				}
			}	
		}
				
			
		/// <summary>
		/// zápis do CSV - na konec souboru
		/// </summary>
		public void SaveCSV()
		{
			using (StreamWriter sw = new StreamWriter(filename, true)) {
				foreach (var record in records) {
					sw.WriteLine("{0};{1};{2};{3};{4}", record.lastName, record.firstName, record.phoneNumber, record.email, record.department);
					sw.Close();
				}
			}
		}
			
	}
}
