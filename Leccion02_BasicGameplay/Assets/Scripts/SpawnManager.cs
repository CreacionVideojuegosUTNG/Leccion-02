using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
---- Nombre: Hernández Salazar Diego Joan
---- Número de control: 1219100490
---- Grupo: GDGS2101-E 
**/

/**
--- Clase para generar objetos (Animales) en la escena en diferentes posiciones
**/
public class SpawnManager : MonoBehaviour
{
    public GameObject[] arrDogs; //Almacenará animales (Objetos) en un arreglo con el nombre arrDogs, 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateAnimal", 1.5F, 1.5F); //invocamos el método CreateAnimal y se va a repetir
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Método para crear animales aleatorios
    void CreateAnimal() //método que no regresa nada / void
    {
        //generamos de manera aleatoria que nos cree un indice 
        int aleatorio = Random.Range(0, arrDogs.Length); //obtenemos el valor de la matriz del array para generar los objetos existentes
        int valx = Random.Range(-20, 20);
           
           //con el metodo Instantiate creamos varios objetos (Animales)
           Instantiate(arrDogs[aleatorio], 
                        new Vector3(valx,
                        0, 11),
                        arrDogs[aleatorio].transform.rotation);
    }
}
