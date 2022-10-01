using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
---- Nombre: Hernández Salazar Diego Joan
---- Número de control: 1219100490
---- Grupo: GDGS2101-E 
**/


/**
--- CLASE PARA ELIMINAR EL OBJETO (HUESO) CUANDO SE SALE DE LA ESCENA
**/

public class MoveDog : MonoBehaviour
{
    float limite = 23; //variable que guardará el limite del objeto en la escena
    float lowerBound = -25; //variable que guardará el limite de los animales

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -limite)
        {
            Destroy(gameObject);    // Se destruye el objeto (hueso) cuando alcanza el limite de la escena
        } else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward*Time.deltaTime*15);
    }
}
