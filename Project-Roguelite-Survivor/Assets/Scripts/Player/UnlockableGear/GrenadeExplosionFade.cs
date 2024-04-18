using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeExplosionFade : MonoBehaviour
{
    public int nadeExplosionLasting = 2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NadeFade());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator NadeFade()
    {
        yield return new WaitForSeconds(nadeExplosionLasting);
        Destroy(gameObject);
    }
}
