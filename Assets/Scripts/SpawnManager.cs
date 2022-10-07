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
    private float spawnArea = 0;
    private float enemyChoose;

    void Update()
    {
        timer += 1;

        if (timer >= enemySpawnTime)
        {
            GameObject shooterE = Instantiate(shooter);
            GameObject creeperE = Instantiate(creeper);

            spawnArea += 1;

            if (spawnArea > 2)
            {
                spawnArea = 0;

            }
            enemyChoose = Random.Range(0, 2);

            if (spawnArea == 0f)
            {
               if (enemyChoose == 1f)
                {
                    shooterE.transform.position = new Vector3(30, 1f, 0);

                }
                else
                {
                    creeperE.transform.position = new Vector3(30, 1f, 0);

                }
                
                
                
            }
            else if (spawnArea == 1f)
            {
                if (enemyChoose == 1f)
                {
                    shooterE.transform.position = new Vector3(0f, 1f, 0f);

                }
                else
                {
                    creeperE.transform.position = new Vector3(0f, 1f, 0f);

                }
                
            }
            else if (spawnArea == 2f)
            {
                if (enemyChoose == 1f)
                {
                    shooterE.transform.position = new Vector3(-30f, 1f, -30f);

                }
                else
                {
                    creeperE.transform.position = new Vector3(-30f, 1f, -30f);

                }
                
            }

            timer = 0;
            if (enemySpawnTime > enemySpawnTimeLimit)
            {
                enemySpawnTime -= 10;
            }
            
            

        }



    }
}
