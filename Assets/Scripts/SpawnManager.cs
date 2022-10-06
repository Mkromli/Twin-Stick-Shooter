using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject shooter;
    [SerializeField] GameObject creeper;
    [SerializeField] private int enemySpawnTime = 300;
    [SerializeField] private int enemySpawnTimeLimit = 120;
    private int timer;
    private float spawnArea;
    private float enemyChoose;

    void Update()
    {
        timer += 1;

        if (timer >= enemySpawnTime)
        {
            GameObject shooterE = Instantiate(shooter);
            GameObject creeperE = Instantiate(creeper);

            spawnArea = Random.Range(0, 3);
            enemyChoose = Random.Range(0, 2);

            if (spawnArea == 0)
            {
               if (enemyChoose == 1)
                {
                    shooterE.transform.position = new Vector3(Random.Range(25f, 47f), 1f, Random.Range(59f, -60f));

                }
                else
                {
                    creeperE.transform.position = new Vector3(Random.Range(25f, 47f), 1f, Random.Range(59f, -60f));

                }
                
                
                
            }
            else if (spawnArea == 1)
            {
                if (enemyChoose > 0.5)
                {
                    shooterE.transform.position = new Vector3(Random.Range(10f, -10f), 1f, Random.Range(-60f, 59f));

                }
                else
                {
                    creeperE.transform.position = new Vector3(Random.Range(10f, -10f), 1f, Random.Range(-60f, 59f));

                }
                ;
            }
            else if (spawnArea == 2)
            {
                if (enemyChoose > 0.5)
                {
                    shooterE.transform.position = new Vector3(Random.Range(-27f, -47f), 1f, Random.Range(59f, -60));

                }
                else
                {
                    creeperE.transform.position = new Vector3(Random.Range(-27f, -47f), 1f, Random.Range(59f, -60));

                }
                
            }

            Debug.Log(spawnArea);
            timer = 0;
            if (enemySpawnTime > enemySpawnTimeLimit)
            {
                enemySpawnTime -= 1;
            }
            
            

        }



    }
}
