using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Player : IPlayers
    {
        public string Name { get; private set; }
        public Weapon Weapon { get; set; }

        public Player(string name, Weapon weapon)
        {
            this.Name = name;
            this.Weapon = weapon;
            this.PrintPlayerInformation();
        }

        public void PrintPlayerInformation()
        {
            Console.WriteLine($"Moxmareblis saxeli {Name}");
            Console.WriteLine($"Moxmareblis {Name} -mier archeuli iaragi {Weapon.WeaponName}");
        }
    }
}


