using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionSys : MonoBehaviour
{
    public static float dropSpeed = 0.5f;
    public GameObject Enemy;
    public GameObject MedKit;
    public Vector3 EnemyPos;
    public static int enemyDur = 6;
    public GameManagerSys hitDetection;
    public GameManagerSys deathDetection;
    public Animator deathEnemyAnim;

    void Start () {
        dropSpeed = 0.5f;
        enemyDur = 6;
    }

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D (Collider2D targetObj) 
    {
       if(targetObj.gameObject.tag == "Bullet")
        {
            enemyDur -=1;
            Destroy(targetObj.gameObject);
            GameManagerSys.hitDetection++;
            if(enemyDur <= 0)
            {
                Instantiate(MedKit, EnemyPos, Quaternion.identity);
                ScoreUI.scr +=3;
                enemyDur = 10;
                GameManagerSys.deathDetection++;
                deathEnemyAnim.GetComponent<Animator>().Play("Death");
                Enemy.GetComponent<BoxCollider2D>().enabled = false;
            }
            
        } 
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        enemyDur -=1;

        if(enemyDur <= 0)
        {
            Destroy(Enemy);
            Debug.Log("Shot");
            Instantiate(MedKit, EnemyPos, Quaternion.identity);
            enemyDur = 10;
        }
    }*/
    void Update () {
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
        EnemyPos = Enemy.transform.position;
    }
}