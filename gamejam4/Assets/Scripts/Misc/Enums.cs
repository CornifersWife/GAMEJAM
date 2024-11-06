public enum GameState
{
    UIMenu,
    GameStarted,
    PlayingLevel,
    Shop,
    BossStage,
    GameLost,
    GameWon
}

public enum GameMode
{
    Normal,
    Hard,
    Endless
}

#region Enemys
    public enum EnemyType
    {
        Melee,
        Ranged,
        Boss
    }

    public enum MeleeEnemyType
    {
        Normal,
        Fast,
        Tank
    }

    public enum RangedEnemyType
    {
        Normal,
        FastAttack,
        Coward
    }

    public enum BossEnemyType
    {
        Normal,
        FastAttack,
        Fast,
        Coward,
        Tank
    }
#endregion


