using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class EnemyClass : CharacterClass
	{
		public EnemyClass(int hp, int maxHP, int damage, TileClass[] characterVision, int x, int y ,tileType typetemp) : base(hp, maxHP, damage, characterVision, x, y, typetemp)
		{

		}
		public override string ToString()
		{
			string infoDisplay = "";
			infoDisplay += x.ToString();
			infoDisplay += y.ToString() + "\n";
			infoDisplay += "Damage:" + damage.ToString();
			return infoDisplay;
			throw new NotImplementedException();
		}
	}
}
