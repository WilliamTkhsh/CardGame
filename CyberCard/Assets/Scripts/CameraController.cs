using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 targetPosition;
    public Quaternion targetRotation;
    public float moveSpeed;

    public bool isMoving = false;

    void FixedUpdate()
    {
        if (isMoving)
        {
            Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            transform.position = newPosition;
            Quaternion newRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, moveSpeed * Time.deltaTime);
            transform.rotation = newRotation;

            // Verifica se a câmera chegou à nova posição
            if (transform.position == targetPosition && transform.rotation == targetRotation)
            {
                isMoving = false;
            }
        }
    }

    public void MoveCamera()
    {
        // Define a nova posição da câmera
        isMoving = true;
    }
}
