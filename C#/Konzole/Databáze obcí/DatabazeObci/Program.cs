using System;

namespace DatabazeObci
{
	class Program
	{
		public static bool konecProgramu = false;
		public static ConsoleKey klavesa;
		public static Zdroj z = new Zdroj();
		public static Grafika g = new Grafika();	
		public static Filtr f = new Filtr();
				
		public static void Main(string[] args)
		{
			g.KonzoleVychozi();
			g.Hlavicka();
			g.Zahlavi();
			z.NactiData(z.filename);
			z.ZobrazTabulku();
			g.Paticka();
			z.VypisStavovyRadek();
			
			while(!konecProgramu) {
				OdchytKlaves();
			}
		}
	
		public static void OdchytKlaves()
		{
			ConsoleKeyInfo cki = Console.ReadKey(true);
			if (cki.Key == ConsoleKey.UpArrow || cki.Key == ConsoleKey.DownArrow || cki.Key == ConsoleKey.PageUp ||
				cki.Key == ConsoleKey.PageDown || cki.Key == ConsoleKey.F10 || cki.Key == ConsoleKey.F1 || 
				cki.Key == ConsoleKey.F2 ||	 cki.Key == ConsoleKey.F3 || cki.Key == ConsoleKey.F4) {
				klavesa = cki.Key;
					
				switch (klavesa) {
					case ConsoleKey.F10:
						konecProgramu = true;
						break;
					case ConsoleKey.UpArrow:
						if (Zdroj.aktualniStrana == 0) {
							break;
						} 	Zdroj.aktualniStrana --;
						Console.SetCursorPosition(0,14);		

						// řazení podle počtu obyvatel ve výpisu po stisku F3						
						if (f.podleObyvatel = true) {
							z.VypisData();
							Console.SetCursorPosition(0,45);			
							z.VypisStavovyRadek();
							break;
						} else					
							z.VypisData(Zdroj.aktualniStrana);
							Console.SetCursorPosition(0,45);			
							z.VypisStavovyRadek();
							break;
						
					case ConsoleKey.DownArrow:
						if ((Zdroj.aktualniStrana + 1) != z.CelkemStran()) {
							Zdroj.aktualniStrana ++;
						} else 
							break;
						Console.SetCursorPosition(0,14);	
						
						// řazení podle počtu obyvatel ve výpisu po stisku F3
						if (f.podleObyvatel = true) {
							z.VypisData();
							Console.SetCursorPosition(0,45);			
							z.VypisStavovyRadek();
							break;
						} else					
							z.VypisData(Zdroj.aktualniStrana);
							Console.SetCursorPosition(0,45);			
							z.VypisStavovyRadek();
							break;
					
					case ConsoleKey.PageUp:
						if (Zdroj.aktualniStrana - 10 < 0) {
							break;
						} 	Zdroj.aktualniStrana = Zdroj.aktualniStrana - 10;
						Console.SetCursorPosition(0,14);	
						
						// řazení podle počtu obyvatel ve výpisu po stisku F3
						if (f.podleObyvatel = true) {
							z.VypisData();
							Console.SetCursorPosition(0,45);			
							z.VypisStavovyRadek();
							break;
						} else					
							z.VypisData(Zdroj.aktualniStrana);
							Console.SetCursorPosition(0,45);			
							z.VypisStavovyRadek();
							break;
						
					case ConsoleKey.PageDown:
						if ((Zdroj.aktualniStrana + 1) != z.CelkemStran()) {
							if (Zdroj.aktualniStrana + 10 > z.CelkemStran()) {
								break;
							}
							Zdroj.aktualniStrana = Zdroj.aktualniStrana + 10;
						} else 
							break;
						Console.SetCursorPosition(0,14);
						
						// řazení podle počtu obyvatel ve výpisu po stisku F3
						if (f.podleObyvatel = true) {
							z.VypisData();
							Console.SetCursorPosition(0,45);			
							z.VypisStavovyRadek();
							break;
						} else					
							z.VypisData(Zdroj.aktualniStrana);
							Console.SetCursorPosition(0,45);			
							z.VypisStavovyRadek();
							break;
						
					case ConsoleKey.F1:
						g.StisknutoF1();					
						break;
						
					case ConsoleKey.F2:				 
						g.StisknutoF2();
						break;
					
					case ConsoleKey.F3:
						g.StisknutoF3();
						break;
					
					case ConsoleKey.F4:
						g.StisknutoF4();
						break;
					}
				}
			}
		}
}