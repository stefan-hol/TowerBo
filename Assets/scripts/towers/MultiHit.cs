using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiHit : Tower
{
    
    private float cooldown = 0;

    void Update()
    {
        cooldown -= Time.deltaTime;

        Enemie[] enemiesInRange = GetAllEnemiesInRange();
          if (enemiesInRange == null)
          return;

          DamageAll(enemiesInRange);

        void DamageAll(Enemie[] enemiesInRange2)
        {
            if (cooldown <= 0)
            {
                for (int i = 0; i < enemiesInRange2.Length; i++)
                {
                    EnemieLevens enemieHP = enemiesInRange2[i].GetComponent<EnemieLevens>();
                    enemieHP.TakeDamage(2);
                    {


                    }
                }
                cooldown = 0.2f;
            }
        }
        }
}