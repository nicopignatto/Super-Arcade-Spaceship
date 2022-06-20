using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalaKeysinE : MonoBehaviour
{
    [Header("Tiempo entre disparos de la Nave Keysin")]
    [SerializeField] private float tiempoEntreDisparosKeysinE;
    private float tiempoActualKeysinE;

    [Header("Linkeos")]
    [SerializeField] private GameObject proyectilKeysin;
   

    private void Start()
    {
        tiempoActualKeysinE = tiempoEntreDisparosKeysinE + 1;
    }

    private void Update()
    {
        SpawnearBalaKeysinE();
    }

    private void SpawnearBalaKeysinE()
    {
        if (tiempoActualKeysinE > tiempoEntreDisparosKeysinE)
        {
            LogicReprodDisparoEKeysin.ReproducirSonidoDisparoEKeysin = true;
            Instantiate(proyectilKeysin, this.transform.position, Quaternion.identity);
            //Debug.Log("La nave keysin dispara");
            tiempoActualKeysinE = 0f;
            //Debug.Log("DESPUES DE QUE LA NAVE K DISPARA el tiempo actual es:" + tiempoActualKeysinE);
        }
        tiempoActualKeysinE += Time.deltaTime;
    }
}
