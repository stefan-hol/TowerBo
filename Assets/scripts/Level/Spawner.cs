using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    
    public Transform enemyPrefab;
    public Transform enemyPrefab1;
    public Transform enemyPrefab2;
    private int r;

    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    private float countdown = 2f;
    public int waveNummer = 0;

    public Text WAVE;
    public Text waveCountDownText;
    private void Update()
    {
        if (countdown <= 0)
        {
            StartCoroutine(spawnWave());
            countdown = timeBetweenWaves;

        }

        countdown -= Time.deltaTime;

        waveCountDownText.text = Mathf.Round(countdown).ToString();
        WAVE.text = "Wave: " + waveNummer;


        IEnumerator spawnWave()
        {
            waveNummer++;

            for (int i = 0; i < waveNummer; i++)
            {
                r = Random.Range(1, 4);
                spawnEnemy();
                yield return new WaitForSeconds(0.25f);
                
            }

        }


        void spawnEnemy()
         {
            if (r == 1)
            {
                Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
                return;
            }
            else if(r == 2)
            {
                Instantiate(enemyPrefab1, spawnPoint.position, spawnPoint.rotation);
                return;
            }
            else if(r == 3)
            {
                Instantiate(enemyPrefab2, spawnPoint.position, spawnPoint.rotation);
            }
        }
    }
}
