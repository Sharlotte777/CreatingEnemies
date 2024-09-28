using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField][Range(1, 10)] private float _timeToSpawn = 1f;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private SpawnPoint TakeRandomPoint()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Count)];
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds waitSpawn = new(_timeToSpawn);

        while (true)
        {
            yield return waitSpawn;

            SpawnPoint point = TakeRandomPoint();

            Enemy enemy = Instantiate(point.GetEnemy(), point.transform.position, Quaternion.identity);
            enemy.SetTarget(point.GetEnemyTarget());
        }
    }
}