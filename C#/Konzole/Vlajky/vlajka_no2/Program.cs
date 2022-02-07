/*
 * Created by SharpDevelop.
 * User: znalec
 * Date: 07.11.2020
 * Time: 16:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace vlajka_no3
{
	class Program
	{
		public static int sirka = 30;
		public static int vyska = 10;
	
		public static void Main(string[] args)
		{
			string pokracuj;
			char volba;
					
			do {
				Console.WriteLine(">>> VLAJKY <<<");
				Console.WriteLine("1 - CZ");
				Console.WriteLine("2 - DE");
				Console.WriteLine("3 - US");
				Console.Write("\nVolba: ");
								
				volba = Console.ReadKey().KeyChar;
				
				switch(volba){
					case '1':
						CZ();
						break;
					case '2':
						DE();
						break;
					case '3':
						US();
						break;
					default:
						Console.WriteLine();
						Console.WriteLine("Zadej pouze hodnotu 1, 2 nebo 3.");
						break; }
													
				Console.WriteLine("Znovu? [Y/N]");
				pokracuj = Console.ReadLine().ToUpper().Trim();
				
				switch (pokracuj){
					case ("Y"):
						break;
					case ("N"):
						Console.WriteLine("\nKončím program.");
						break;
					default:
						Console.WriteLine("Zadej pouze Y nebo N.");	
						Console.WriteLine("\nZnovu? [Y/N]");
						pokracuj = Console.ReadLine().ToUpper().Trim();
						continue;}
					}
								
			while (pokracuj == "Y");
				
			Console.ReadKey(true);
		}
		
		
			
		public static void DE()
		{
			Console.WriteLine();
			for (int i = 1; i <= vyska; i++){ 
	            for (int j = 1; j <= sirka; j++){ 
	            	if (i <= vyska/3)
	                    Console.Write("█");
					else if (i > vyska/3 * 2)
						Console.Write("▒");
					else
						Console.Write("░");	
				}
				Console.WriteLine();
			}
		
			Console.WriteLine();
		}
		
		public static void US()
		{
			Console.WriteLine();
			for (int i = 1; i <= vyska; i++){ 
	            for (int j = 1; j <= sirka; j++){ 
	            	if (i <= vyska/2 && j <= sirka/2)
	                    Console.Write("*");
					else
						Console.Write("░");
				}	
	            Console.WriteLine();
			}
			Console.WriteLine();
		
			Console.WriteLine();
		}
		
		public static void CZ()
		{
			Console.WriteLine();
			for (int i = 1; i <= vyska/2; i++){ 
	            for (int j = 1; j <= sirka; j++){           	            		
	            	if (i <= vyska/2 && j < i*3)
	            		Console.Write("░");
	            	else
	            		Console.Write("█");         	     	
	          	}
	          	Console.WriteLine();
			}
						
			for (int i = vyska/2; i > 0; i--){
				for (int j = 1; j <= sirka; j++){			
	            	if (i <= vyska/2 && j < i*3) 
	            		Console.Write("░");
	            	else
	            		Console.Write("▒");
	          	}	
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		
		
	}
}