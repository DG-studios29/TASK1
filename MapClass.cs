using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class MapClass
	{
		Random roll = new Random();
		// assigning the variables.
		public int width { get; set; }
		public TileClass[,] Map { get; set; }
		public EnemyClass[] Enemies { get; set; }
		public int height { get; set; }
		public MapClass(int widthMin, int widthMax, int heightMin, int heightMax, int numofEnemies)
		{
			Enemies = new EnemyClass[numofEnemies];
			width = 10;
			height = 10;
			Map = new TileClass[height, width];

			TileClass hero = Create(TileClass.tileType.Hero);
			Map[hero.X, hero.Y] = hero;

			for (int i = 0; i < numofEnemies; i++)
			{
				TileClass goblin = Create(TileClass.tileType.Enemy);
				Map[goblin.X, goblin.Y] = goblin;
			}
		}

	
		public override string ToString()
		{
			return base.ToString();
		}

		int randomRoll(int value1, int value2)
		{
			return roll.Next(value1, value2);

		}
		public void UpdateVision()
		{

		}
		
		TileClass Create(TileClass.tileType type)
		{
			TileClass temp = null;

			int x = randomRoll(0, width);
			int y = randomRoll(0, height);

			while(Map[x,y] != null)
			{
				x = randomRoll(0, width);
				y = randomRoll(0, height);
			}

			switch(type)
			{
				case TileClass.tileType.Enemy:
					GoblinClass newgoblin = new GoblinClass(10,100,1,null,x,y, TileClass.tileType.Enemy);
					temp = newgoblin;
					break;
				case TileClass.tileType.Hero:
					HeroClass newhero = new HeroClass(10, 100, 2, null, x, y, TileClass.tileType.Hero);
					temp = newhero;
					break;

			}
			return temp;
		}
	}
}
