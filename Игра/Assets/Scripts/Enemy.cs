using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Enemy : Units {
        public abstract int Lives { get; set; }
        public abstract int CountCointsAfterKill { get; set; }
        public abstract int SpeedX { get; set; }
        public abstract Weapon Weapon { get; set; }
        public abstract Rigidbody2D Body { get; set; }
    }
}
