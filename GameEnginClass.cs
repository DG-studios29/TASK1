using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class GameEnginClass
	{
		private char[,] map;

		public GameEnginClass()
		{
			Mclass = new MapClass(0,10,0,10,2);
		}
		MapClass Mclass;
		public char[,] Map
		{
			get
			{
				return map;
			}
			set
			{
				map = value;
			}
		}
		public bool MovePlayer(CharacterClass.Movement direction)
		{
			return true;
		}

		public override string ToString()
		{ /// display the 2d tile array
			string disply = "";
			for (int y = 0; y < Mclass.height; y++)
			{
				for (int x = 0; x < Mclass.width; x++)
				{
					if (Mclass.Map[x, y] == null)
					{
						disply += ".";
					}
					else if (Mclass.Map[x,y].type.Equals(TileClass.tileType.Hero))
					{
						disply += "H";
					}
					else if(Mclass.Map[x, y].type.Equals(TileClass.tileType.Enemy))
					{
						disply += "G";
					}
					if (y == 0 || y == Mclass.width - 1)
					{
						disply += "X";
					}
					else
					{
						if (y == 0 || y == Mclass.height - 1)
						{
							disply += "X";
						}
					}
				}
				disply += "\n";
			}

			return disply;
	
		}
	}
}
