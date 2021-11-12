using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : Tower
{
    private float cooldown = 0;
    [SerializeField] private Transform _turret;
    private void Update()
    {
        cooldown -= Time.deltaTime;

        Enemie enemy = GetFirstEnemyInRange();
        
        if (enemy != null)
        {
            EnemieLevens enemyHP = enemy.GetComponent<EnemieLevens>();
            _turret.LookAt(enemy.transform);
            if(cooldown <= 0)
            {
                enemyHP.TakeDamage(5);
                cooldown = 0.9f;
            }
        }
    }
}

