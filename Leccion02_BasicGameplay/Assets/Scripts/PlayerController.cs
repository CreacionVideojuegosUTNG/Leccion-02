using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
---- Nombre: Hernández Salazar Diego Joan
---- Número de control: 1219100490
---- Grupo: GDGS2101-E 
**/

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject proyectilBone; // alamcenamos un objeto con GameObject, aquí almacenamos el hueso desde Unity, y en Inspector arrastramos el objeto.
    float horInput;
    float limiteMov = 20; //variable para establecer el límite de movimiento del objeto y controlar su movimiento en la escena del juego

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Limita el campo de movimineto del Player (Objeto), se asegura que el objeto no salga de la escena
        if(transform.position.x > limiteMov){ //Derecha, Obtenemos la pocision del objeto y lo limitamos a la derecha
            transform.position = new Vector3(limiteMov, transform.position.y, transform.position.z); //la posición del jugador solo llegará a un limite de 20
        }
        if(transform.position.x < -limiteMov){  //Izquierda, La posicion no debe ser mayor a 20, para que no salga de la escena hacia la iziquierda
            transform.position = new Vector3(-limiteMov, transform.position.y, transform.position.z);
        }

        //Crea un hueso en la posision del Player
        if(Input.GetKeyDown(KeyCode.Space)){ //acedemos al valor space de nuestro teclado, para saber cuando se preciona, GetKeyDown = cuando se mantiene precionada una tecla, KeyUp = Cuando se suelta una tecla
            //se lanzará el hueso desde la posición del jugador
            Instantiate(proyectilBone, transform.position, proyectilBone.transform.rotation); //el método instantiate crea muchos objetos (huesos)
        }

        // Movimientos del Player
        horInput = Input.GetAxis("Horizontal"); //obtenemos el valor cada vez que se teclea izquierda o derecha
        transform.Translate(Vector3.right*Time.deltaTime*20*horInput); //movemos al objeto segun nuestro horInput, con el translate se hace la función de mover
    }
}
