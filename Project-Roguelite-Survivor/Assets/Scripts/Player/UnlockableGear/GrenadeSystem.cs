using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeSystem : MonoBehaviour
{
    
    public GameObject Grenade;
    public GameObject Explosion;
    Vector3 areaZero;
    public int nadeVelocity = 2;
    public int nadeTimer = 20;
    GameObject ShieldG;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = Grenade.GetComponent<Rigidbody>();
        rb.AddRelativeForce(nadeVelocity * Vector3.forward, ForceMode.Impulse);

    }
    // Update is called once per frame
    void Update()
    {
        areaZero = gameObject.transform.position;
    }

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag == "Ground")
        {
            StartCoroutine(TickTickBoom());
        }
    }

    IEnumerator TickTickBoom()
    {
        while (true)
        {
            yield return new WaitForSeconds(nadeTimer);
            Instantiate(Explosion, areaZero, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
