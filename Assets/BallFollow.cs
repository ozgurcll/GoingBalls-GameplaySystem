using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollow : MonoBehaviour
{
    private Transform player;
    public float distance = 2f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void LateUpdate()
    {
        if (player == null)
            return;

        Vector3 playerPosition = player.position;

        Vector3 newPosition = playerPosition - transform.forward * distance;

        transform.position = newPosition;

        transform.LookAt(playerPosition);
    }
}
