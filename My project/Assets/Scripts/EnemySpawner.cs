using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _spawnTime = 1f;
    [SerializeField] private List<Transform> _spawnPoints = new();
    [SerializeField] private Enemy _enemy;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds secondsUntilSpawn = new(_spawnTime);

        while (true)
        {
            yield return secondsUntilSpawn;

            Enemy enemy = Instantiate(_enemy, GetRandomPoint().position, Quaternion.identity);
            enemy.Init(GetRandomDirection());
        }
    }

    private Vector3 GetRandomDirection()
    {
        return new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
    }

    private Transform GetRandomPoint()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Count)];
    }
}
