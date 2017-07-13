using UnityEngine;

namespace Assets.Scripts.Players
{
    class HeroMarsel : HeroAbstract
    {
        public override int Lives { get; set; }
        public override float ForceJump { get; set; }
        public override float SpeedX { get; set; }
        public override int CountCoints { get; set; }
        public override bool IsGrounded { get; set; }
        public override float Direction { get; set; }
        public override Rigidbody2D Body { get; set; }
        public override SpriteRenderer Sprite { get; set; }
        public override GunAbstract Gun { get; set; }

        void Awake()
        {
            Lives = 3;
            ForceJump = 2f;
            SpeedX = 3f;
            CountCoints = 0;
            IsGrounded = true;
            Direction = 1f;
            Body = GetComponent<Rigidbody2D>();
            Sprite = GetComponentInChildren<SpriteRenderer>();
            Gun=new GunPistol();
        }

        void Update()
        {
            if (Input.GetButton("Horizontal")) Run();
            if (Input.GetButton("Jump")) Jump();
            if (Input.GetButton("Fire1")) Shoot();
        }

        public override void Run()
        {
            Direction = Input.GetAxis("Horizontal");
            Sprite.flipX = Direction > 0;
            base.Run();
        }

        public override void Jump()
        {
            base.Jump();
        }

        public override void Shoot()
        {
            base.Shoot();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            base.OnCollisionEnter2DAbsctract(collision);
        }
    }
}
