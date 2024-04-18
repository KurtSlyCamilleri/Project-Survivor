using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeSystem : MonoBehaviour
{
    
    public GameObject Grenade;
    public static int nadeVelocity = 2;

    


    // Start is called before the first frame update
    void Start()
    {
        
        Rigidbody rb = Grenade.GetComponent<Rigidbody>();
        rb.AddForce(nadeVelocity * Vector3.forward, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
