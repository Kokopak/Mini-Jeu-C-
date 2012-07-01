using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotMys
{
	class Program
	{
		static void Main(string[] args)
		{
			Jeu jeu = new Jeu();
			List<string> mots = new List<string> { "cochon", "vache", "taureau" };
			Console.WriteLine(jeu.ShuffleList(mots)[0]);
		}
	}
}
