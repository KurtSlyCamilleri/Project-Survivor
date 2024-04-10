using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomSpawnSys : MonoBehaviour
{

    public GameObject fruit;
    public GameObject Scrap;
    public GameObject Enemy;
    public float x = 0f;
    public static float running = 0; 
    public int spawnOne = 0;
    public int spawnTwo = 0;
    public int spawnThree = 0;
    public static int spawnRate1 = 3;
    public static int spawnRate2 = 6;
    public static int spawnRate3 = 8;

    void Start()
    {
        StartCoroutine("SpawnRoutine1");
    }

    public void SpawnScrap()
    {
        StartCoroutine("SpawnRoutine2");
    }

    public void SpawnEnemies()
    {
        
        StartCoroutine("SpawnRoutine3");
    }

    IEnumerator SpawnRoutine1()
    {
        while(running == 0)
        {
            spawnOne = Random.Range(0,10);
            if(spawnOne == 1)
            {
                
                Vector3 pos1 = new Vector3(x-7, transform.position.y + 1);
                Instantiate(fruit, pos1, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
            else if(spawnOne == 2)
            {
                Vector3 pos2 = new Vector3(x-5, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
            else if(spawnOne == 3)
            {
                Vector3 pos2 = new Vector3(x-3, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
            else if(spawnOne == 4)
            {
                Vector3 pos2 = new Vector3(x-1, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
            else if(spawnOne == 5)
            {
                Vector3 pos2 = new Vector3(x+1, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
            else if(spawnOne == 6)
            {
                Vector3 pos2 = new Vector3(x+3, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
            else if(spawnOne == 7)
            {
                Vector3 pos2 = new Vector3(x+5, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
            else if(spawnOne == 8)
            {
                Vector3 pos2 = new Vector3(x+7, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
            else if(spawnOne == 9)
            {
                Vector3 pos2 = new Vector3(x-9, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
            else
            {
                Vector3 pos2 = new Vector3(x+9, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
                
            }
        }
    }

    IEnumerator SpawnRoutine2()
    {
        while(running == 0)
        {
            spawnTwo = Random.Range(0,10);
            if(spawnTwo == 1)
            {
                Vector3 pos1 = new Vector3(x-7, transform.position.y + 1);
                Instantiate(Scrap, pos1, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
            else if(spawnTwo == 2)
            {
                Vector3 pos2 = new Vector3(x-5, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
            else if(spawnTwo == 3)
            {
                Vector3 pos2 = new Vector3(x-3, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
            else if(spawnTwo == 4)
            {
                Vector3 pos2 = new Vector3(x-1, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
            else if(spawnTwo == 5)
            {
                Vector3 pos2 = new Vector3(x+1, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
            else if(spawnTwo == 6)
            {
                Vector3 pos2 = new Vector3(x+3, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
            else if(spawnTwo == 7)
            {
                Vector3 pos2 = new Vector3(x+5, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
            else if(spawnTwo == 8)
            {
                Vector3 pos2 = new Vector3(x+7, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
            else if(spawnTwo == 9)
            {
                Vector3 pos2 = new Vector3(x-9, transform.position.y + 1);
                Instantiate(Scrap, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
            else
            {
                Vector3 pos2 = new Vector3(x+9, transform.position.y + 1);
                Instantiate(fruit, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
                
            }
        }
    }

    IEnumerator SpawnRoutine3()
    {
        while(running == 0)
        {
            spawnThree = Random.Range(0,10);
            if(spawnOne == 1)
            {
                Vector3 pos1 = new Vector3(x-7, transform.position.y + 1);
                Instantiate(Enemy, pos1, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
            else if(spawnThree == 2)
            {
                Vector3 pos2 = new Vector3(x-5, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
            else if(spawnThree == 3)
            {
                Vector3 pos2 = new Vector3(x-3, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
            else if(spawnThree == 4)
            {
                Vector3 pos2 = new Vector3(x-1, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
            else if(spawnThree == 5)
            {
                Vector3 pos2 = new Vector3(x+1, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
            else if(spawnThree == 6)
            {
                Vector3 pos2 = new Vector3(x+3, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
            else if(spawnThree == 7)
            {
                Vector3 pos2 = new Vector3(x+5, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
            else if(spawnThree == 8)
            {
                Vector3 pos2 = new Vector3(x+7, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
            else if(spawnThree == 9)
            {
                Vector3 pos2 = new Vector3(x-9, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
            else
            {
                Vector3 pos2 = new Vector3(x+9, transform.position.y + 1);
                Instantiate(Enemy, pos2, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
                
            }
        }
    }
}