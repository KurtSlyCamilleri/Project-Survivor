using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public GameObject player;
    public Transform target;

    // Start is called before the first frame update

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(target.position);
    }

  
}
