using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    private bool isRotating = false;

    [SerializeField]
    private float rotationSpeed = 100f;
    private int rotationDirection = 0; // 0 = sin rotación, 1 = horario, -1 = antihorario

    // Establecer la dirección de rotación
    public void SetRotationDirection(int direction)
    {
        rotationDirection = direction;
        isRotating = direction != 0;
    }

    // Método para detener la rotación
    public void StopRotation()
    {
        isRotating = false;
        rotationDirection = 0;
    }

    // Método que controla la rotación
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up * rotationDirection * rotationSpeed * Time.deltaTime);
        }
    }
}