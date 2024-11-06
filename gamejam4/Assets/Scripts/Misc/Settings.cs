namespace Misc
{
    public static class Settings
    {
        public static int[] multiplierTAB = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        public static int multiplier = 0;
        
        #region PLAYER SETTINGS

            public const float PLAYER_SPEED = 16f;
            public const float PLAYER_ATTACK_SPEED = 16f;

        #endregion
        
        #region ENEMY_MELEE_SETTINGS

        public const float ENEMY_MELEE_HP = 20;
        public const float ENEMY_MELEE_SPEED = 16f;
        
        public const float ENEMY_MELEE_ATTACK = 5;
        public const float ENEMY_MELEE_ATTACK_SPEED = 16f;

        #endregion
        
        #region ENEMY_RANGE_SETTINGS

        public const float ENEMY_RANGE_HP = 20;
        public const float ENEMY_RANGE_SPEED = 16f;
        
        public const float ENEMY_RANGE_ATTACK = 5;
        public const float ENEMY_RANGE_ATTACK_SPEED = 16f;

        #endregion
        
        #region ENEMY_BOSS_SETTINGS

        public const float ENEMY_BOSS_HP = 20;
        public const float ENEMY_BOSS_SPEED = 16f;
        
        public const float ENEMY_BOSS_ATTACK = 5;
        public const float ENEMY_BOSS_ATTACK_SPEED = 16f;

        #endregion
    }
}