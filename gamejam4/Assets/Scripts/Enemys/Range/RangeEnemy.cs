using System;
using Misc;

namespace Enemys.Range
{
    public class RangeEnemy
    {
        public static Guid ID = Guid.NewGuid();
        
        public float HP = Settings.ENEMY_RANGE_HP;
        public float Speed = Settings.ENEMY_RANGE_SPEED;
        
        public float Attack = Settings.ENEMY_RANGE_ATTACK;
        public float AttackSpeed = Settings.ENEMY_RANGE_ATTACK_SPEED;
    }
}