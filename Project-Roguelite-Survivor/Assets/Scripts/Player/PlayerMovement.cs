using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

}
