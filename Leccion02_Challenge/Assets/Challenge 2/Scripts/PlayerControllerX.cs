using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
--- Hernández Salazar Diego Joan
--- GDGS2101
--- 1219100490
**/

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab; //OBJETO PERRO
    private float tiempo = 1;//variable para el tiempo
    private float tiempoSiguiente = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoSiguiente)
        {
            tiempoSiguiente = Time.time + tiempo;//actualizamos 
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation); //instanciamos copias de los perros
        }
    }
}
