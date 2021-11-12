using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _arrivalThreshold;
    private Path _path;
    private WayPoint _currentWaypoint;
    private float speed;
    private PlayerLevens playerHP;
    private void Start()
    {
        GameObject playerHPGO = GameObject.Find("spawner");
        playerHP = playerHPGO.GetComponent<PlayerLevens>();
        SetupPath();

    }

    void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
        transform.LookAt(_currentWaypoint.GetPosition());
    }
    private void Update()
    {
        speed = GetComponent<Enemie>().snelheid;

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float DistanceToWaypoint = Vector3.Distance(transform.position, _currentWaypoint.GetPosition());
        WayPoint End = _path.GetPathEnd();

        if (DistanceToWaypoint <= _arrivalThreshold)
        {
            if (_path.GetPathEnd() == _currentWaypoint)
            {
                PathComplete();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
                transform.LookAt(_currentWaypoint.GetPosition());
            }
        }


    }

    void PathComplete()
    {
        playerHP.TakeDamage(1);
        Destroy(gameObject);
    }
}