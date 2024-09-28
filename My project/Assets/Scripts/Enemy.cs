using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField][Range(1, 15)] private int _speed;
    private Transform _target;

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}