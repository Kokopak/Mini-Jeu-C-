using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pendu
{
	class Pendu
	{
		public string mot;
		private List<string> mots = new List<string> { "cochon", "vache", "taureau", "poule", "mouton", "chien" };
		public List<char> motca = new List<char>();

		public Pendu()
		{
			Random ran = new Random();
			int index = ran.Next(0, mots.Count);
			mot = mots[index];
			foreach (char l in mot)
			{
				motca.Add('*');
			}
		}
		public string jeu(char lettre)
		{
			foreach (var iter in mot.Select((Value, Index) => new { Value, Index }))
			{
				if (iter.Value == lettre)
				{
					motca[iter.Index] = lettre;
				}
			}
			return string.Join("", motca.ToArray());
		}

	}
}
