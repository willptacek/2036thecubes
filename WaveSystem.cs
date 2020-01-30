using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    public GameObject enemypf;
    public Transform player;
    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
    public static GameObject[] enemyClone;
    private int xPos, zPos;
    public static int WaveNumber = 0;

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyClone = enemies;
        
        if (enemies.Length == 1)
        {
            WaveNumber++;
            if (WaveNumber % 5 == 0)
            {
                //every 5 waves, increase enemy movement speed by 1
                enemyBehavior.movementSpeed++;
            }
            if (WaveNumber <= 10)
            {
                for (int i = 0; i < WaveNumber; i++)
                {
                    SpawnEnemy();
                }
            }
            if(WaveNumber > 10)
            {
                if(WaveNumber % 10 == 0)//every 10th wave, spawn double enemies
                {
                    for (int i = 0; i < WaveNumber; i++)
                    {
                        SpawnEnemy();
                        SpawnEnemy();
                    }
                }
                else
                {
                    SpawnEnemy();//after wave 10, spawns 1 more enemy
                    for (int i = 0; i < WaveNumber; i++)
                    {
                        SpawnEnemy();
                    }
                }
            }
        }
    }
    
    void SpawnEnemy()
    {
        do
        {
            xPos = Random.Range(-25, 25);
            zPos = Random.Range(-25, 25);
        } while (!(xPos > player.transform.position.x + 5 || xPos < player.transform.position.x -5));
        GameObject enemyObject = Instantiate(enemypf, new Vector3(xPos, 2, zPos), Quaternion.identity);
    }
}
