using System;
using Enemys.Boss;
using Enemys.Melee;
using Enemys.Range;

namespace Enemys.Spawn
{
    public class EnemyFactory
    {
        public void CreateEnemy(Guid ID, EnemyType enemyType, MeleeEnemyType? meleeEnemyType, RangedEnemyType? rangedEnemyType, BossEnemyType? bossEnemyType )
        {
            switch (enemyType)
            {
                case EnemyType.Melee:
                    CreateMeleeEnemy(ID, meleeEnemyType);
                    break;
                case EnemyType.Ranged:
                    CreateRangedEnemy(ID, rangedEnemyType);
                    break;
                case EnemyType.Boss:
                    CreateBossEnemy(ID, bossEnemyType);
                    break;
            }
        }

        private BossEnemy CreateBossEnemy(Guid id, BossEnemyType? bossEnemyType)
        {
            switch (bossEnemyType)
            {
                case BossEnemyType.Normal:
                    return new BossEnemy();
                case BossEnemyType.Coward:
                    return new CowardBossEnemy(ID);
                case BossEnemyType.Fast:
                    return new FastBossEnemy(ID);
                case BossEnemyType.Tank:
                    return new TankBossEnemy(ID);
                case BossEnemyType.FastAttack:
                    return new FastAttackBossEnemy(ID);
                default:
                    return null;
            }
        }

        private RangeEnemy CreateRangedEnemy(Guid ID, RangedEnemyType? rangedEnemyType)
        {
            switch (rangedEnemyType)
            {
                case RangedEnemyType.Coward:
                    return new CowardRangedEnemy(ID);
                case RangedEnemyType.Normal:
                    return new RangeEnemy();
                case RangedEnemyType.FastAttack:
                    return new FastAttackRangedEnemy(ID);
                default:
                    return null;
            }
        }

        private MeleeEnemy CreateMeleeEnemy(Guid ID, MeleeEnemyType? meleeEnemyType)
        {
            switch (meleeEnemyType)
            {
                case MeleeEnemyType.Normal:
                    return new MeleeEnemy();
                case MeleeEnemyType.Fast:
                    return new FastMeleeEnemy(ID);
                case MeleeEnemyType.Tank:
                    return new TankMeleeEnemy(ID);
                default:
                    return null;
            }
        }

        private class FastMeleeEnemy : MeleeEnemy
        {
            public FastMeleeEnemy(Guid id)
            {
                throw new NotImplementedException();
            }
        }
    }
}