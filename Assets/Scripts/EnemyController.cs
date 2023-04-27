using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform target; //drag and stop player object in the inspector
    public NavMeshAgent enemy;
    public float within_range;
    public float speed;

    public void Update()
    {
        enemy.SetDestination(target.position);
    }
}
