using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTakenDetect : MonoBehaviour
{
    public GameObject PlayerCyan;
    public GameObject PlayerRed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider targetObj)
    {
        StartCoroutine(DamageTakenRoutine());
    }

        IEnumerator DamageTakenRoutine()
    {
        PlayerCyan.SetActive(false);
        PlayerRed.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        PlayerCyan.SetActive(true);
        PlayerRed.SetActive(false);
        yield return new WaitForSeconds(0.1f);
    }
}
