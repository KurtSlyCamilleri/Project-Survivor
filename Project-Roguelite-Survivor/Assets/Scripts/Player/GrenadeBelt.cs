using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeBelt : MonoBehaviour
{
    public GameObject Grenade;
    public Transform Player;
    public int throwSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GrenadeBeltRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }
    IEnumerator GrenadeBeltRoutine()
    {
        while (true)
        {
            Instantiate(Grenade, new Vector3(Player.position.x, Player.position.y + 0.2f, Player.position.z), Quaternion.identity);
            yield return new WaitForSeconds(throwSpeed);
        }
    }
}
