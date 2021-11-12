using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevensComponent : MonoBehaviour
{
    [SerializeField] private float _startHealth;
    public float _currentHealth;
    
    private void Start()
    {
        _currentHealth = _startHealth;
    }


    public void TakeDamage(float amount)
    {
        _currentHealth -= amount;

        print(message: _currentHealth);

        if (_currentHealth <= 0)
        {
            Death();
        }

    }
    protected virtual void Death()
    { 

    }
}