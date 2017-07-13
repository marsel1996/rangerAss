using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class HeroAbstract :Units {
        public abstract int Lives { get; set; }
        public abstract float ForceJump { get; set; }
        public abstract float SpeedX { get; set; }
        public abstract int CountCoints { get; set; }
        public abstract bool IsGrounded { get; set; }
        public abstract float Direction { get; set; }
        public abstract Rigidbody2D Body { get; set; }
        public abstract SpriteRenderer Sprite { get; set; }
        public abstract GunAbstract Gun { get; set; }
        
        public virtual void Run()
        {
            Vector3 target = new Vector3(Body.transform.position.x + (SpeedX * Direction), Body.transform.position.y, 0);
            transform.position = Vector3.Lerp(Body.transform.position, target, Time.deltaTime);
        }

        public virtual void Jump()
        {
            if (IsGrounded)
            {
                Body.AddForce(Vector2.up * ForceJump,ForceMode2D.Impulse);
            }
        }

        public virtual void Shoot()
        {
            Gun.Attack();
        }

        public virtual void OnCollisionEnter2DAbsctract(Collision2D collision)
        {
            Debug.Log(collision.collider.gameObject.tag);
            if (collision.collider.gameObject.tag == "Player")
            {
                Physics2D.IgnoreCollision(collision.collider, this.GetComponent<CircleCollider2D>());
            }
        }
    }
}
