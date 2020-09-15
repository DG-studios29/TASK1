using System;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	abstract class CharacterClass : TileClass
	{
		public enum Movement
		{	// assigning the enums
			Nomovement,
			Up,
			Down,
			Left,
			Right
		}


		protected int HP;
		public int hp
		{
			get
			{
				return HP;
			}
			set
			{
				HP = value;
			}
		}


		protected int MaxHP;
		public int maxHP
		{
			get
			{
				return MaxHP;
			}
			set
			{
				MaxHP = value;
			}
		}



		protected int Damage;
		public int damage
		{
			get
			{
				return Damage;
			}
			set
			{
				Damage = value;
			}
		}



		protected TileClass[] characterVision;
		public TileClass[] CharacterVision
		{
			get
			{
				return characterVision;
			}
			set
			{
				characterVision = value;
			}
		}
			// constu
		public CharacterClass(int temphp, int tempmaxHP, int tempdamage, TileClass[] tempcharacterVision, int x, int y, tileType typetemp) : base(x, y,typetemp)
		{

			this.hp = temphp;
			this.maxHP = tempmaxHP;
			this.damage = tempdamage;
			CharacterVision = tempcharacterVision;

		}
		public virtual void Attack(CharacterClass target)
		{
			target.HP -= -this.Damage;
		}
		public bool IsDead()
		{
			if (HP >= 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public virtual bool checkRange(CharacterClass target)
		{
			// use distanceto < 1 return true
			if (DistanceTo(target) > 1)
			{
				return true;

			}
			else
			{// use distanceto > 1 return true

				return false;
			}

		}
		private int DistanceTo(CharacterClass target)
		{
			return (Math.Abs(base.x - target.x) + Math.Abs(base.y - target.y));
		}

		public void Move(Movement move)
		{
			switch (move)
			{
				case Movement.Nomovement:
					break;
				case Movement.Up:
					y -= 1;
					break;
				case Movement.Down:
					y += 1;
					break;
				case Movement.Left:
					x -= 1;
					break;
				case Movement.Right:
					x += 1;
					break;
			}
		}

		public abstract override string ToString();

		

		
	}
}

