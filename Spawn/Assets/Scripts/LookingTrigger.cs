using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingTrigger : MonoBehaviour
{
    [Range(0f, 1f)]

    public float threshold = 0.5f;

    public float dotProduct = 0f;

    public Transform playerTransform;

    private void OnDrawGizmos()
    {
        Vector2 position = transform.position;
        Vector2 playerPosition = playerTransform.position;
        Vector2 playerLookDir = playerTransform.right;

        Vector2 playerToEnemyDir = (position - playerPosition).normalized;

        float lookingTowards = Vector2.Dot(playerToEnemyDir, playerLookDir);

        dotProduct = lookingTowards;

        bool seePlayer = lookingTowards >= threshold;

        Gizmos.color = seePlayer ? Color.green : Color.red;
        Gizmos.DrawLine(position, playerPosition + playerToEnemyDir);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(playerPosition, playerPosition + playerLookDir);
        
    }
}
