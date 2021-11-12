using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] protected float radius;
    [SerializeField] private LayerMask _layer;

    public Enemie[] GetAllEnemiesInRange()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, radius, _layer);
        if (colls.Length <= 0)
        {
            return null;
        }

        List<Enemie> enemiesInRange = new List<Enemie>();
        for (int i = 0; i < colls.Length; i++)
        {
            enemiesInRange.Add(colls[i].GetComponent<Enemie>());
        }
        return enemiesInRange.ToArray();

    }
    public Enemie GetFirstEnemyInRange()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, radius, _layer);
        if (colls.Length <= 0)
        {
            return null;
        }
        return colls[0].GetComponent<Enemie>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}