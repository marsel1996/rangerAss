using NUnit.Framework;

namespace Assets.Scripts
{
    public abstract class GunAbstract : Weapon {

        public abstract Bullet Bullet { get; set; }
        public abstract int CountBullet { get; set; }

        public override void Attack()
        {

        }
    }
}
