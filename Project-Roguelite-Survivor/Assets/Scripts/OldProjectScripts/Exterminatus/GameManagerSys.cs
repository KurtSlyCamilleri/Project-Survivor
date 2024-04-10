using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerSys : MonoBehaviour
{
    public RandomSpawnSys running;
    public HealthUI hp;
    public static int Timer = 0;
    public TextMeshProUGUI playtimer;
    public static int Difficulty = 0;
    public static int SpawnScrap = 0;
    public static int SpawnEnemy = 0;
    public static GameObject Comet;
    public static GameObject Scrap;
    public static GameObject Enemy;
    public AudioSource source;

    public AudioClip enemyHit;
    public AudioClip enemyDead;
    public AudioClip upgraded;

    public static int hitDetection = 0;
    public static int deathDetection = 0;
    public static int upgradeDetection = 0;

    void Update()
    {
        if(hitDetection == 1)
        {
            source.PlayOneShot(enemyHit);
            hitDetection--;
        }
        if(deathDetection == 1)
        {
            source.PlayOneShot(enemyDead);
            deathDetection--;
        }
        if(upgradeDetection == 1)
        {
            source.PlayOneShot(upgraded);
            upgradeDetection--;
        }
    }


    
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        Difficulty = 0;
        SpawnScrap = 0;
        SpawnEnemy = 0;
        StartCoroutine("GameTimer");
        GameObject.Destroy(Comet);
        GameObject.Destroy(Scrap);
        GameObject.Destroy(Enemy);
    }

    // Update is called once per frame
    IEnumerator GameTimer()
    {
        while (RandomSpawnSys.running == 0)
        {
            yield return new WaitForSeconds(1);
            
            Timer++;
            playtimer.SetText("Time: " + Timer.ToString());

            if(HealthUI.hp == 0)
            {
                SceneManager.LoadScene("Over");
            }

            if(Timer >= Difficulty)
            {
                EnemyCollisionSys.dropSpeed += 0.1f;
                ScrapCollisionSys.dropSpeed += 0.3f;
                CometCollisionSys.dropSpeed += 0.5f;
                ScoreUI.scr +=5;
                Difficulty += 30;
            }

            if(Timer == 600)
            {
                RandomSpawnSys.spawnRate1=1;
                RandomSpawnSys.spawnRate2=3;
                RandomSpawnSys.spawnRate3=5;
                
            }
            else if(Timer == 400)
            {
                RandomSpawnSys.spawnRate1=1;
                RandomSpawnSys.spawnRate2=4;
                RandomSpawnSys.spawnRate3=6;
                SpawnEnemy += 1;
            }
            else if(Timer == 200)
            {
                RandomSpawnSys.spawnRate1=2;
                RandomSpawnSys.spawnRate2=5;
                RandomSpawnSys.spawnRate3=7;
                Difficulty += 100;
                
            }
            else if(Timer == 90)
            {
                running.SpawnEnemies();
            }
            else if(Timer == 30)
            {
                running.SpawnScrap();
            }

        }

        //EnemyCollisionSys.dropSpeed += 1.0f;

    }

}
