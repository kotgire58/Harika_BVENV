using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviourTree;

public class EnemyAI : MonoBehaviour
{
    private Node _root;
    public Transform player;
    public Transform[] waypoints;
    private NavMeshAgent agent;

    public float chaseRange = 5f;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        Node patrol = new PatrolNode(agent, waypoints);
        Node chase = new ChaseNode(agent, player, chaseRange);

        _root = new Selector(new List<Node> { chase, patrol });
    }

    private void Update()
    {
        _root?.Evaluate();
    }
}
    