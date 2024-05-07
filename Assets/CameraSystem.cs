using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSystem : MonoBehaviour
{
    public float followHeight = 7f;
    public float followDistance = 6f;
    public float followHeightSpeed = 0.9f;

    public Transform player;

    private float targetHeight;
    private float currentHeight;

    private void Awake()
    {

    }


    void LateUpdate()
    {
        targetHeight = player.position.y + followHeight;

        currentHeight = Mathf.Lerp(transform.position.y, targetHeight, followHeightSpeed * Time.deltaTime);

        Quaternion euler = Quaternion.Euler(0f, currentHeight, 0f);

        Vector3 targetPosition = player.position - (euler * Vector3.forward) * followDistance;

        targetPosition.y = currentHeight;

        transform.position = targetPosition;
        transform.LookAt(player);
    }
}
