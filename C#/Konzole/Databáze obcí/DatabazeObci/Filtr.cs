
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabazeObci
{
	/// <summary>
	/// Description of Filtr.
	/// </summary>
	public class Filtr
	{
		public Zdroj z = new Zdroj();
		public Grafika g = new Grafika();
		public List<Obec> seznamObjektu = new List<Obec>();
		
		public string retezecObec {	get; set; }
		public int min { get; set; }
		public int max { get; set; }
		public string retezecKraj {	get; set; }
		public bool podleObyvatel = false;
		
		
		/// <summary>
		/// metoda pro zobrazení obcí podle zadaných počátečních písmen, ignoruje velká/malá písmena
		/// </summary>
		/// <param name="retezecObec">řetezec vložený uživatelem</param>
		public void FiltrPodleObce(string retezecObec)
		{
			Console.ResetColor();
			foreach (Obec o in Zdroj.seznamTemp) {
				Zdroj.seznamTemp = Zdroj.seznamTemp.Where(x => x.nazev.StartsWith(retezecObec) || x.nazev.ToLower().StartsWith(retezecObec.ToLower())).ToList();
			}
			VratAktualniStrana();			
			Console.SetCursorPosition(0, 14);
			z.VypisData(Zdroj.aktualniStrana);
			Console.SetCursorPosition(0,45);			
			z.VypisStavovyRadekDleFiltru();
		}
		
		
		
		/// <summary>
		/// vrátí aktuální stranu na začátek - pro zobrazení výpisu po použití filtru
		/// </summary>
		/// <returns></returns>
		public int VratAktualniStrana()
		{
			if (Zdroj.AktualniStrana(Program.klavesa)!=0)
				Zdroj.aktualniStrana = 0;
			return Zdroj.aktualniStrana;
		}
				
		/// <summary>
		/// metoda pro zobrazení obcí podle podle kraje - delší doba vyhledávání a řazení
		/// </summary>
		/// <param name="retezecKraj">řetezec vložený uživatelem</param>
		public void FiltrPodleKraje(string retezecKraj)
		{
			Console.ResetColor();
			foreach (Obec o in Zdroj.seznamTemp) {
				Zdroj.seznamTemp = Zdroj.seznamTemp.Where(x => x.kraj.StartsWith(retezecKraj) || x.kraj.ToLower().StartsWith(retezecKraj.ToLower())).ToList();
			}
			VratAktualniStrana();			
			Console.SetCursorPosition(0, 14);
			z.VypisData(Zdroj.aktualniStrana);
			Console.SetCursorPosition(0,45);			
			z.VypisStavovyRadekDleFiltru();
		}
		
		/// <summary>
		/// metoda pro zobrazení obcí podle počtu obyvatel v rozsahu zadaném uživatelem
		/// </summary>
		/// <param name="min">spodní hranice počtu obyvatel</param>
		/// <param name="max">horní hranice počtu obyvatel</param>
		public void FiltrPodleObyvatel(int min, int max)
		{
			Console.ResetColor();
			foreach (Obec o in Zdroj.seznamTemp) {
				Zdroj.seznamTemp = Zdroj.seznamTemp.Where(x => x.pocetObyvatel >= min && x.pocetObyvatel <= max).ToList();
			}
			VratAktualniStrana();	
			podleObyvatel = true;
			Console.SetCursorPosition(0, 14);
			z.VypisData(Zdroj.aktualniStrana);
			Console.SetCursorPosition(0,45);			
			z.VypisStavovyRadekDleFiltru();
		}

		
		public List<Obec> BubbleSort(List<Obec> seznamObjektu)
		{
			for (int i = 0; i < seznamObjektu.Count-1; i++) {
				for (int j = 0; j < seznamObjektu.Count-i-1; j++) {
					if (seznamObjektu[j+1].pocetObyvatel < seznamObjektu[j].pocetObyvatel) {
						Obec temp = seznamObjektu[j+1];
						seznamObjektu[j+1] = seznamObjektu[j];
						seznamObjektu[j] = temp;
					}
				}
			}
			return seznamObjektu;
		}
		
		public Filtr()
		{			
		}
	}
}
