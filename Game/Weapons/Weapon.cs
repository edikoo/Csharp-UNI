using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    abstract class Weapon
    {
        public abstract string WeaponName { get; }
        public abstract int Damage { get; }

    }
}
