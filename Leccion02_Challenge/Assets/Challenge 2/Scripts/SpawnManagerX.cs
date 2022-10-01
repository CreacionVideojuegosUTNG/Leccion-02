using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
--- Hernández Salazar Diego Joan
--- GDGS2101
--- 1219100490
**/

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //rivate float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int pelota = Random.Range(0,3);//variable que generará los objetos que existen dentro de la escena (Pelotas) 
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[pelota], spawnPos, ballPrefabs[0].transform.rotation);

        startDelay = Random.Range(1,5);//tiempo aleatorio

        Invoke("SpawnRandomBall", startDelay); //se vuelve a llamar a la funcion con el nuevo intervalo de espera
    }

}
