using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public GameObject Pause;
    public float speed = 0.5f;
    Rigidbody rb;
    public GameObject Player;

    // Update is called once per frame



    void Start () {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        

        float vertical =Input.GetAxis("Vertical");
        float horizontal =Input.GetAxis("Horizontal");


        Vector3 motion12Vector = new Vector3(0, 0, vertical);
        Vector3 motion13Vector = new Vector3(horizontal, 0, 0);


        transform.Translate(motion12Vector *speed *Time.deltaTime);
        transform.Translate(motion13Vector * speed * Time.deltaTime);



        //if (Input.GetKeyDown("escape"))
        //{
        //Pause.SetActive(true);
        //}


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
