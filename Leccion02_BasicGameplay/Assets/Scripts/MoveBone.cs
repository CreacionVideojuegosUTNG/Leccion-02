using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
---- Nombre: Hernández Salazar Diego Joan
---- Número de control: 1219100490
---- Grupo: GDGS2101-E 
**/

/**
---- MÉTODO PARA MOVER EL HUESO EN LA ESCENA 
**/
public class MoveBone : MonoBehaviour
{
    public float distance = 21; //variable para controlar la distancia del hueso

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mover el hueso
        if(transform.position.z > distance){
            Destroy(gameObject);    // Se destruye el proyecto
        }
        transform.Translate(Vector3.forward*Time.deltaTime*20); //transladamos el objeto (hueso) hacia adelante con FORWAR
    }
}
