using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class MoverByPoints : MonoBehaviour
{
    [SerializeField] private Transform _path;

    private Transform[] _points;
    private int _neededPoint;
    private Enemy _enemy;
    private Transform _target;

    private void Awake()
    {
        _enemy = GetComponent<Enemy>();

        SetPoints();

        _target = _points[_neededPoint];
        _enemy.SetTarget(_target);
    }

    private void Update()
    {
        if (transform.position == _target.position)
        {
            SetNextTarget();
        }
    }

    private void SetNextTarget()
    {
        _neededPoint++;

        if (_neededPoint >= _points.Length)
        {
            _neededPoint = 0;
        }

        _enemy.SetTarget(_points[_neededPoint]);
        _target = _points[_neededPoint];
    }

    private void SetPoints()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }
}
