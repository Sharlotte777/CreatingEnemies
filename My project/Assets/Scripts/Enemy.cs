using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField][Range(1, 25)] private float _speed;
    private Vector3 _direction;

    private void Update()
    {
        Move();
    }

    public void Init(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move()
    {
        transform.Translate(_direction * (_speed * Time.deltaTime));
    }
}
