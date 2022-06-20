using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovRielEnemigo : MonoBehaviour
{
    [Header("Velocidad del riel")]
    [Range(4.5f,8f)]
    [Tooltip("Este slider determina entre que velocidades se puede mover hacia adelante el riel del Enemigo Keysin")]
    [SerializeField] private float velRielEnemigo;

    /*[Header("Límites del mov. del riel por el escenario")]
    [SerializeField] private float limiteAbajo;*/

    /*[Header("Punto de reinicio del mov. del riel")]
    [SerializeField] private float puntoDeInicioEnY;*/
    private void Update()
    {
        MovimientoRiel();
        /*if (transform.position.y < limiteAbajo)
        {
            transform.position = new Vector3(0f, puntoDeInicioEnY);
        }*/
       
    }

    private void MovimientoRiel()
    {
        transform.Translate(Vector3.down * velRielEnemigo * Time.deltaTime, Space.World);
       
    }
}
