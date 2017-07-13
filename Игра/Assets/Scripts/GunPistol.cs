
using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class GunPistol: GunAbstract {
        public override float RangeAttack { get; set; }

        public override TimeSpan TimeRechange { get; set; }

        public override Bullet Bullet { get; set; }

        public override int CountBullet { get; set; }

        public override void Attack()
        {
            Debug.Log("PR PR PR");
            base.Attack();
        }

        void Awake()
        {
            RangeAttack = 10f;
            TimeRechange = TimeSpan.Zero;
        }
    }
}
