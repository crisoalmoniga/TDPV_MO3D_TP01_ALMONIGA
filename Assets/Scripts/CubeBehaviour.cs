using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    private bool isRotating = false;

    [SerializeField]
    private float rotationSpeed = 100f;
    private int rotationDirection = 0; // 0 = sin rotaci�n, 1 = horario, -1 = antihorario

    // Establecer la direcci�n de rotaci�n
    public void SetRotationDirection(int direction)
    {
        rotationDirection = direction;
        isRotating = direction != 0;
    }

    // M�todo para detener la rotaci�n
    public void StopRotation()
    {
        isRotating = false;
        rotationDirection = 0;
    }

    // M�todo que controla la rotaci�n
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up * rotationDirection * rotationSpeed * Time.deltaTime);
        }
    }
}