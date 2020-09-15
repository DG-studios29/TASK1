using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class HeroClass : CharacterClass
	{
		protected int HeroHP;
		public int herohp
		{
			get
			{
				return HeroHP;
			}
			set 
			{
				HeroHP = value;
			}
		}
		protected int HeroMaxHP;
		public int heromaxhp
		{
			get
			{
				return HeroMaxHP;
			}
			set
			{
				HeroMaxHP = value;
			}
		}
		protected int HeroDamage = 2;
		public int herodamage
		{
			get
			{
				return HeroDamage;
			}
			set
			{
				HeroDamage = value;
			}
		}

		public HeroClass(int hp, int maxHP, int damage, TileClass[] characterVision, int x, int y, tileType typetemp) : base(hp, maxHP, damage, characterVision, x, y,typetemp)
		{
			HeroHP = hp;
			HeroMaxHP = maxHP;
			HeroDamage = damage;
		}

		public override string ToString()
		{
			string infoDisplay = "";
			infoDisplay += "Player Stats:" + HeroHP.ToString() + "\n";
			infoDisplay += x.ToString() ;
			infoDisplay += y.ToString() ;
			infoDisplay += "Damage: 2"+ damage.ToString() + "\n";
			return infoDisplay;
			throw new NotImplementedException();
		}
	}
}
