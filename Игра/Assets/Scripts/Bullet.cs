using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Bullet : Units {
        public abstract int Damage { get; set; }

        void OnTriggerEnter2D(Collider2D other)
        {

        }
    }
}
