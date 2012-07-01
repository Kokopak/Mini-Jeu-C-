using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morpion
{
	class Morpion
	{	
		string case1 = "1";
		string case2 = "2";
		string case3 = "3";
		string case4 = "4";
		string case5 = "5";
		string case6 = "6";
		string case7 = "7";
		string case8 = "8";
		string case9 = "9";
		
		public void draw_grille()
		{
			Console.WriteLine(case1 + "|" + case2 + "|" + case3);
			Console.WriteLine("-+-+-");
			Console.WriteLine(case4 + "|" + case5 + "|" + case6);
			Console.WriteLine("-+-+-");
			Console.WriteLine(case7 + "|" + case8 + "|" + case9);
		}

		public void poser(string carac, string place)
		{
			switch (place)
			{
				case "c1":
					if (case1 != "X" && case1 != "O") case1 = carac;
					else Console.WriteLine("Déplacement impossible !");
					break;
				case "c2":
					if (case2 != "X" && case2 != "O") case2 = carac;
					else Console.WriteLine("Déplacement impossible !");
					break;
				case "c3":
					if (case3 != "X" && case3 != "O") case3 = carac;
					else Console.WriteLine("Déplacement impossible !");
					break;
				case "c4":
					if (case4 != "X" && case4 != "O") case4 = carac;
					else Console.WriteLine("Déplacement impossible !");
					break;
				case "c5":
					if (case5 != "X" && case5 != "O") case5 = carac;
					else Console.WriteLine("Déplacement impossible !");
					break;
				case "c6":
					if (case6 != "X" && case6 != "O") case6 = carac;
					else Console.WriteLine("Déplacement impossible !");
					break;
				case "c7":
					if (case7 != "X" && case7 != "O") case7 = carac;
					else Console.WriteLine("Déplacement impossible !");
					break;
				case "c8":
					if (case8 != "X" && case8 != "O") case8 = carac;
					else Console.WriteLine("Déplacement impossible !");
					break;
				case "c9":
					if (case9 != "X" && case9 != "O") case9 = carac;
					else Console.WriteLine("Déplacement impossible !");
					break;
			}
		}
		public void gagnant()
		{
			if (case1 == "X" && case2 == "X" && case3 == "X" || case1 == "O" && case2 == "O" && case3 == "O")
			{
				draw_grille();
				Console.WriteLine("Gagné !");
				Environment.Exit(0);
			}
			else if (case4 == "X" && case5 == "X" && case6 == "X" || case4 == "O" && case5 == "O" && case6 == "O")
			{
				draw_grille();
				Console.WriteLine("Gagné !");
				Environment.Exit(0);
			}
			else if (case7 == "X" && case8 == "X" && case9 == "X" || case7 == "O" && case8 == "O" && case9 == "O")
			{
				draw_grille();
				Console.WriteLine("Gagné !");
				Environment.Exit(0);
			}
			else if (case1 == "X" && case4 == "X" && case7 == "X" || case1 == "O" && case4 == "O" && case7 == "O")
			{
				draw_grille();
				Console.WriteLine("Gagné !");
				Environment.Exit(0);
			}
			else if (case2 == "X" && case5 == "X" && case8 == "X" || case2 == "O" && case5 == "O" && case8 == "O")
			{
				draw_grille();
				Console.WriteLine("Gagné !");
				Environment.Exit(0);
			}
			else if (case3 == "X" && case6 == "X" && case9 == "X" || case3 == "O" && case6 == "O" && case9 == "O")
			{
				draw_grille();
				Console.WriteLine("Gagné !");
				Environment.Exit(0);
			}
			else if (case1 == "X" && case5 == "X" && case9 == "X" || case1 == "O" && case5 == "O" && case9 == "O")
			{
				draw_grille();
				Console.WriteLine("Gagné !");
				Environment.Exit(0);
			}
			else if (case3 == "X" && case5 == "X" && case7 == "X" || case3 == "O" && case5 == "O" && case7 == "O")
			{
				draw_grille();
				Console.WriteLine("Gagné !");
				Environment.Exit(0);
			}
		}
	}
}
