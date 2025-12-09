using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    // Reference to the player's transform
    public Transform player;

    // Reference to NavMeshAgent which moves the enemy
    private NavMeshAgent agent;

    void Start()
    {
        // Get the NavMeshAgent component
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Constantly update the enemy's target position to chase the player
        agent.SetDestination(player.position);
    }
}


