using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometCollisionSys : MonoBehaviour
{
    public static float dropSpeed = 1.0f;
    public GameObject fruit;
    public GameObject RateKit;
    public Vector3 CometPos;
    public GameManagerSys deathDetection;
    public Animator deathCometAnim;

    void Start () {
        dropSpeed = 1.0f;
    }

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(fruit);
        Debug.Log("Shot");
        
    }*/

    void OnTriggerEnter2D (Collider2D targetObj) 
    {
       if(targetObj.gameObject.tag == "Bullet")
        {
            Destroy(targetObj.gameObject);
            Instantiate(RateKit, CometPos, Quaternion.identity);
            ScoreUI.scr +=1;
            GameManagerSys.deathDetection++;
            deathCometAnim.GetComponent<Animator>().Play("Death");
            fruit.GetComponent<BoxCollider2D>().enabled = false;
        } 
    }

    void Update () {
        CometPos = fruit.transform.position;
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
    }
}