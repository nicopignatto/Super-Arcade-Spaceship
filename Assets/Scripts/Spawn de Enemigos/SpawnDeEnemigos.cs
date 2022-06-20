using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDeEnemigos : MonoBehaviour
{
    [Header("Enemigo al que instanciar")]
    [SerializeField] private GameObject keysinE;//acá estamos referenciando al enemigo que queremos que el spawn spawnee durante el juego.

    [Header("Tiempo de reaparición de enemigos")]
    [Tooltip("esta slider determina cada cuantos segundos se respawnean los enemigos en el spawn")]
    [Range(3.2f,10f)]
    [SerializeField] private float tiempoEntreSpawnDeE;
    [SerializeField] private float tiempoEntreCambioPosSpawnE;

    private float tiempoActualSpawnE;
    private float tiempoActualPosSpawnE;
    private int posAleatoriaX;
    private int posAleatoriaY;
    private void Start()
    {
    
        tiempoActualSpawnE = tiempoEntreSpawnDeE + 1;
        tiempoActualPosSpawnE = tiempoEntreCambioPosSpawnE + 1;
    }

    private void Update()
    {
        SpawnearEnemigosK();
        CambiarPosSpawn();
    }
    private void SpawnearEnemigosK()
    {
        if (tiempoActualSpawnE > tiempoEntreSpawnDeE)
        {
            tiempoActualSpawnE = 0f;
            Instantiate(keysinE, this.transform.position,Quaternion.identity);
        }
        tiempoActualSpawnE += Time.deltaTime;
    }

    private void CambiarPosSpawn()
    {
        if (tiempoActualPosSpawnE > tiempoEntreCambioPosSpawnE)
        {
            tiempoActualPosSpawnE = 0f;
            posAleatoriaX = Random.Range(9, 12);
            posAleatoriaY = Random.Range(-3, 2);
            gameObject.transform.position = new Vector3(posAleatoriaX, posAleatoriaY, 0f);

        }
        tiempoActualPosSpawnE += Time.deltaTime;
    }
}
