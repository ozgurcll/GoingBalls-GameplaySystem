using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotator : MonoBehaviour
{
    public Transform ball;
    public float rotationSpeed = 5f;

    void Update()
    {
        if (ball == null)
            return;

        float verticalInput = Input.GetAxis("Vertical");

        if (verticalInput > 0)
        {
            Quaternion targetRotation = Quaternion.Euler(0f, 0, 0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        else if (verticalInput < 0)
        {
            Quaternion targetRotation = Quaternion.Euler(0f, 180f, 0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
