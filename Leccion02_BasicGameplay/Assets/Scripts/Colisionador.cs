using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
---- Nombre: Hernández Salazar Diego Joan
---- Número de control: 1219100490
---- Grupo: GDGS2101-E 
**/

/**
CLASE PARA DESTRUIR LOS ANIMALES CUNADO RECIBAN UN OBJETO, (HUESO)
**/

public class Colisionador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void OnTriggerEnter(Collider other)
    {
         Destroy(gameObject); //destruimos el objeto (animal)
         Destroy(other.gameObject);   
    }
}
