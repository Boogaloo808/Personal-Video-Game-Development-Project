using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Ai;

public class enemy : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    //Patroling
    public Vector3 walkpoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenattacks;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;


    private void Awake()
    {
        player = GameObject.Finf("PlayerObj").transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerINAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInAttackRange && playerInSightRange) AttackPlayer();
    }

    private void ChasePlayer()
    {

    }

    private void ChasePlayer()
    {

    }

    private void AttackPlayer()
    {

    }
}
