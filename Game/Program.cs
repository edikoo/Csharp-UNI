using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = CreatePlayer();
            Player player2 = CreatePlayer();

            GameManager gameManager = new GameManager(player1, player2);
        }

        public static Player CreatePlayer()
        {
            Console.WriteLine("Gtxovt Sheiyvanot Momxmarebelis Saxeli: ");
            string PlayerName = Console.ReadLine();
            var weapons = new List<Weapon> { new Riffle(), new Pistol(), new ShotGun() };
            Console.WriteLine("Gtxovt Airchiot Iaragi: ");
            int c = 1;
            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine($"{c}) {weapon.WeaponName}");
                c++;
            }
            int getInput = Convert.ToInt32(Console.ReadLine()) - 1;
            return new Player(PlayerName, weapons[getInput]);
        }

       
    }
}
