using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacter
{
    class GameCharacter
    {
        private int health;

        public string Name
        {
            get;
            set;
        }

        public int Health
        {
            set 
            {
                if (value <= 0)
                {
                    this.health = 0;
                }
                else if(value >= 100)
                {
                    this.health = 0;
                }
                this.health = value;
            }
            get { return this.health; }
        }

        public GameCharacter(string name)
        {
            Name = name;
        }

        public GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void RecievedDamage(int damage)
        {
            Health -= damage;
        }

        public string GetHealthInfo()
        {
            return $"Current health: {Health}/100";
        }

        public static GameCharacter CompareHealth(GameCharacter a, GameCharacter b)
        {
            if (a.Health >= b.Health)
            {
                return a;
            }
            return b;
        }
    }
}
