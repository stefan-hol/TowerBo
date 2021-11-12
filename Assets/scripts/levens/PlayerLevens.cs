using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerLevens : LevensComponent
{
    public Text playerLevens;
    private void Update()
    {
        playerLevens.text = "levens: " + _currentHealth;
    }
    protected override void Death()
    {
        base.Death();
        SceneManager.LoadScene(2);
    }
}
