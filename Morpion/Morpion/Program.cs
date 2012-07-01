using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morpion
{
	class Program
	{
		static void Main(string[] args)
		{
			Morpion morp = new Morpion();
			int tour_player = 0;
			bool gain = false;

			while (!gain)
			{
				morp.draw_grille();
				Console.Write("Joueur"+tour_player+": ");
				string a = Console.ReadLine();
				switch (a)
				{
					case "1":
						if (tour_player == 0)
						{
							morp.poser("X", "c1");
							tour_player = 1;
						}
						else
						{
							morp.poser("O", "c1");
							tour_player = 0;
						}
						break;
					case "2":
						if (tour_player == 0)
						{
							morp.poser("X", "c2");
							tour_player = 1;
						}
						else
						{
							morp.poser("O", "c2");
							tour_player = 0;
						}
						break;
					case "3":
						if (tour_player == 0)
						{
							morp.poser("X", "c3");
							tour_player = 1;
						}
						else
						{
							morp.poser("O", "c3");
							tour_player = 0;
						}
						break;
					case "4":
						if (tour_player == 0)
						{
							morp.poser("X", "c4");
							tour_player = 1;
						}
						else
						{
							morp.poser("O", "c4");
							tour_player = 0;
						}
						break;
					case "5":
						if (tour_player == 0)
						{
							morp.poser("X", "c5");
							tour_player = 1;
						}
						else
						{
							morp.poser("O", "c5");
							tour_player = 0;
						}
						break;
					case "6":
						if (tour_player == 0)
						{
							morp.poser("X", "c6");
							tour_player = 1;
						}
						else
						{
							morp.poser("O", "c6");
							tour_player = 0;
						}
						break;
					case "7":
						if (tour_player == 0)
						{
							morp.poser("X", "c7");
							tour_player = 1;
						}
						else
						{
							morp.poser("O", "c7");
							tour_player = 0;
						}
						break;
					case "8":
						if (tour_player == 0)
						{
							morp.poser("X", "c8");
							tour_player = 1;
						}
						else
						{
							morp.poser("O", "c8");
							tour_player = 0;
						}
						break;
					case "9":
						if (tour_player == 0)
						{
							morp.poser("X", "c9");
							tour_player = 1;
						}
						else
						{
							morp.poser("O", "c9");
							tour_player = 0;
						}
						break;
				}
				morp.gagnant();
			}
			morp.terminer();
		}
	}
}
