using System;

namespace Assets.Scripts
{
    public abstract class Weapon :Units
    {
        public abstract float RangeAttack { get; set; }
        public abstract TimeSpan TimeRechange { get; set; }

        public abstract void Attack();
    }
}
