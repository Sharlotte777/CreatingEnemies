using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _enemyTarget;

    public Transform GetEnemyTarget()
    {
        return _enemyTarget;
    }

    public Enemy GetEnemy()
    {
        return _enemy;
    }
}