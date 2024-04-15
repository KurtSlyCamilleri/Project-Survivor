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

    // Update is called once per frame



    void Start () 
    {

    }

    void Update()
    {
        transform.Translate(motionVector * speed * Time.deltaTime);



        //if (Input.GetKeyDown("escape"))
        //{
        //Pause.SetActive(true);
        //}


    }

    void OnMove(InputValue value)
    {
        var v2 = value.Get<Vector2>();
        motionVector = new Vector3(v2.x, 0, v2.y);
    }










    //IEnumerator Dash()
    //{
    //    while(true) 
    //    {
    //stamina--;

    //yield return new WaitForSeconds(3f);
    //}
    //}

}
