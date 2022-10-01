using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
--- Hernández Salazar Diego Joan
--- GDGS2101
--- 1219100490
**/

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -38; //variable que controlará el campo del perro en la escena
    private float bottomLimit = -4; //variable que controlará el campo de las pelotas en la escena

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit) // cuando es menor al limite se destruye
        {
            Destroy(gameObject); // se destruye el objeto
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.z < bottomLimit) //si las bolas son menores al bottom se destruyen
        {
            Destroy(gameObject);
        }

    }
}
