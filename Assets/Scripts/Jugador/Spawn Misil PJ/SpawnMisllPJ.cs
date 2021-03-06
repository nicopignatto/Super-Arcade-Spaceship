using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMisllPJ : MonoBehaviour
{
    [Header("Tiempo entre disparos del personaje")]
    [SerializeField] private float tiempoEntreDisparos;
    private float tiempoActual;

    [Header("Linkeos")]
    [SerializeField] private GameObject misilPJ;

    private float inputL2;

    private bool puedoSpawnear;
    

    private void Start()
    {
        puedoSpawnear = false;
        tiempoActual = tiempoEntreDisparos + 1;
    }
    private void Update()
    {
        SpawnearMisil();
    }
    private void SpawnearMisil()
    {
        if (Input.GetButton("Fire3") || Input.GetKey(KeyCode.Space))
        {

            if (tiempoActual > tiempoEntreDisparos)
            {
                LogicReprodDisparosPJ.ReproducirSonidoDisparoPJ = true;
                Instantiate(misilPJ, this.transform.position, Quaternion.identity);
                tiempoActual = 0;
                //Debug.Log("DESPU?S DE DISPARAR tiempo actuaL es:" + tiempoActual);
            }
        }
        tiempoActual += Time.deltaTime;
    }

}
