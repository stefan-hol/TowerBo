using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowmo : Tower
{
    List<Enemie> slowedEnemies = new List<Enemie>();
    private void Update()
    {

        Enemie[] enemiesInRange = GetAllEnemiesInRange();
        
        if (enemiesInRange == null)
            return;

        ApplySlowEffect(enemiesInRange);
       // CleanSlowedEnemies(enemiesInRange);
    }

    private void ApplySlowEffect(Enemie[] enemiesInRange)
    {
        for (int i = 0; i < enemiesInRange.Length; i++)
        {
            if (!slowedEnemies.Contains(enemiesInRange[i]))
            {
                enemiesInRange[i].snelheid *= 0.8f;
                slowedEnemies.Add(enemiesInRange[i]);

            }
        }
    }
    /*
private void CleanSlowedEnemies(Enemie[] enemiesInRange)
{
List<Enemie> enemiesNotInRangeAnymore = new List<Enemie>();
for (int i = 0; i < slowedEnemies.Count; i++)
{
    float distance = Vector3.Distance(transform.position, slowedEnemies[i].transform.position);
    if (distance > radius + 0.8f)
    {
        enemiesNotInRangeAnymore.Add(slowedEnemies[i]);
        slowedEnemies[i].snelheid *= 2;
    }
}
// clean enemies in range list
for (int i = 0; i < enemiesNotInRangeAnymore.Count; i++)
{
    slowedEnemies.Remove(enemiesNotInRangeAnymore[i]);
}

List<Enemie> enemiesNotInRangeAnymore = new List<Enemie>();

// get enemies who are not in range anymore
for (int i = 0; i < slowedEnemies.Count; i++)
{
    for (int j = 0; j < enemiesInRange.Length; j++)
    {
        if (slowedEnemies[i] == enemiesInRange[j]) continue;
        else
        {
            // set enemy speed back to normal
            enemiesNotInRangeAnymore.Add(slowedEnemies[i]);
            slowedEnemies[i].snelheid *= 1.2f;
        }
    }
}

// clean enemies in range list
for (int i = 0; i < enemiesNotInRangeAnymore.Count; i++)
{
    slowedEnemies.Remove(enemiesNotInRangeAnymore[i]);
}

}
*/
}