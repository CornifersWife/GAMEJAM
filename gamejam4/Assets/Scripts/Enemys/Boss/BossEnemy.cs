using System;
using Misc;

namespace Enemys.Boss
{
    public class BossEnemy
    {
        public static Guid ID = Guid.NewGuid();
        
        public float HP = Settings.ENEMY_BOSS_HP;
        public float Speed = Settings.ENEMY_BOSS_SPEED;
        
        public float Attack = Settings.ENEMY_BOSS_ATTACK;
        public float AttackSpeed = Settings.ENEMY_BOSS_ATTACK_SPEED;
    }
}