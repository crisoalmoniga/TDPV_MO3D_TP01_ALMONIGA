using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public CubeBehaviour cubeBehaviour;

    void Update()
    {
        // Girar en sentido horario con la tecla Right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            cubeBehaviour.SetRotationDirection(1);
        }

        // Girar en sentido antihorario con la tecla Left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            cubeBehaviour.SetRotationDirection(-1);
        }

        // Detener la rotación con la tecla Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubeBehaviour.StopRotation();
        }
    }
}