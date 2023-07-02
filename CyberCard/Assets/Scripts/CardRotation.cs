using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRotation : MonoBehaviour
{

    public float targetAngle = 30f; // Ângulo de rotação desejado em graus
    public float targetAngle2 = -80f; // Ângulo de rotação desejado em graus
    public float rotationSpeed = 10f; // Velocidade de rotação em graus por segundo
    private Quaternion targetRotation; // Rotação desejada do objeto
    private Quaternion targetRotation2; // Rotação desejada do objeto
    [SerializeField] private bool rotateClockwise = true;
    private void Start()
    {
        targetRotation = Quaternion.Euler(0f, targetAngle, 0f);
        targetRotation2 = Quaternion.Euler(0f, targetAngle2, 0f);
    }

    private void Update()
    {
        Quaternion nextRotation;

        if (rotateClockwise)
        {
            nextRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
        else
        {
            nextRotation = Quaternion.RotateTowards(transform.rotation, targetRotation2, Time.deltaTime * rotationSpeed);
        }

        // Aplica a rotação ao objeto
        transform.rotation = nextRotation;

        // Verifica se a rotação atingiu o ângulo desejado
        if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f || Quaternion.Angle(transform.rotation, targetRotation2) < 0.1f)
        {
            // Inverte a direção da rotação
            rotateClockwise = !rotateClockwise;
        }
    }
}