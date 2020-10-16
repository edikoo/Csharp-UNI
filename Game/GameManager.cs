using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GameManager
    {
        public GameManager(Player player1, Player player2)
        {
            Console.WriteLine("");

            if (player1.Weapon.Damage > player2.Weapon.Damage)
            {
                Console.WriteLine($"Gamarjvebulia {player1.Name}");
            }
            else if(player1.Weapon.Damage == player2.Weapon.Damage)
            {
                Console.WriteLine("Dasrulda Fre");
            }
            else
            {
                Console.WriteLine($"Gamarjvebulia {player2.Name}");
            }
        }

    }
}
