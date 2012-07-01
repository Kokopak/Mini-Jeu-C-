using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pendu
{
	class Program
	{
		static void Main(string[] args)
		{
			Pendu pen = new Pendu();
			int coup = 11;
			bool ok = false;
			Console.WriteLine(string.Join("", pen.motca.ToArray()));
 			while (!ok)
			{
				try
				{
					Console.Write("Lettre: ");
					string let = Console.ReadLine();
					Console.WriteLine(pen.jeu(let[0]));

					if (string.Join("", pen.motca.ToArray()) == pen.mot)
					{
						Console.WriteLine("Bravo !");
						Console.Write("Appuyez sur une touche pour continuer...");
						Console.Read();
						ok = true;
					}
					if (pen.mot.Contains(let[0]) == false)
					{
						coup -= 1;
						Console.WriteLine("Non ! Coup(s) restant(s): " + coup);
					}
					if (coup <= 0)
					{
						Console.WriteLine("Perdu ! Le mot était: " + pen.mot);
						Console.Write("Appuyez sur une touche pour continuer...");
						Console.Read();
						ok = true;
					}
				}
				catch (System.IndexOutOfRangeException e)
				{
					Console.WriteLine("Erreur !");
					Console.WriteLine(string.Join("", pen.motca.ToArray()));
				}
			}
		}
	}
}
