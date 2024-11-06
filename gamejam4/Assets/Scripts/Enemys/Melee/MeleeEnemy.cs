using System;
using Misc;
using UnityEditor;

namespace Enemys.Melee
{
    public class MeleeEnemy
    {
        public static Guid ID = Guid.NewGuid();
        
        public float HP = Settings.ENEMY_MELEE_HP;
        public float Speed = Settings.ENEMY_MELEE_SPEED;
        
        public float Attack = Settings.ENEMY_MELEE_ATTACK;
        public float AttackSpeed = Settings.ENEMY_MELEE_ATTACK_SPEED;
        
    }
}