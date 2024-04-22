using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //public GameObject Pause;
    public float speed = 0.5f;
    public GameObject Player;

    private Vector3 motionVector = Vector3.zero;


    void Start () 
    {
        speed = 0.5f;
    }

    void Update()
    {
        transform.Translate(motionVector *speed *Time.deltaTime);



        //if (Input.GetKeyDown("escape"))
        //{
        //Pause.SetActive(true);
        //}


    }

    private void OnMove(InputValue value)
    {
        var vector = value.Get<Vector2>();
        motionVector = new Vector3(vector.x, 0, vector.y);
    }

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "SpongeWave")
        {
            StartCoroutine(Slowed());
            
        }
    }

    IEnumerator Slowed()
    {

            speed = 0.45f;
            yield return new WaitForSeconds(2.5f);
            speed = 0.5f;
            yield return new WaitForSeconds(0.5f);

    }

}
