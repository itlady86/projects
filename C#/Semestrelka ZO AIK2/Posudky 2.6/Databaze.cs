using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Posudky
{
	public class Databaze
	{
		public string fileName = "database-100.json";
		public string passCislo;
		public int index;

		public List<Root> LoadJson()
		{
			if (File.Exists(fileName))
			{
				string jsonText = File.ReadAllText(fileName);
				var output = JsonConvert.DeserializeObject<List<Root>>(jsonText);
				return output;
			}
			return null;
		}

	}
}





