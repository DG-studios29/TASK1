using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class GoblinClass : EnemyClass
	{
		protected int GoblinHp = 10;
		public int goblinhp
		{
			get
			{
				return GoblinHp;
			}
			set
			{
				GoblinHp = value;
			}
		}
		protected int Goblindamage;
		public int goblindamage
		{
			get
			{
				return Goblindamage;
			}
			set
			{
				Goblindamage = value;
			}
		}

		public GoblinClass(int hp, int maxHP, int damage, TileClass[] characterVision, int x, int y, tileType typetemp) : base(hp, maxHP, damage, characterVision, x, y, typetemp)
		{
			GoblinHp = hp;
			Goblindamage = damage;
		}
		
		
	}
	
}
