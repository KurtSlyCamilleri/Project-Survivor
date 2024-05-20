using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedback : MonoBehaviour
{
    public float linger = 0.5f;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("FeedbackSpawned");
        Player = GameObject.FindWithTag("Player");
        transform.rotation = Player.transform.rotation;
        StartCoroutine(Fade());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(linger);
        Destroy(gameObject);
    }
}
