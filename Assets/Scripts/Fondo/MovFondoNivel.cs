using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFondoNivel : MonoBehaviour
{
    [Header("velocidad de movimiento del fondo")]
    [SerializeField] private float velFondo;

    [Header("Punto de inicio del movimiento del fondo del nivel")]
    [SerializeField] private float puntoInicial;

    [Header("Límite de movimiento del juego")]
    [SerializeField] private float limiteAbajo;

    //private bool llegoAlLimite;

    private void Start()
    {
        //llegoAlLimite = false;
    }
    private void Update()
    {
        transform.Translate(Vector3.down * velFondo * Time.deltaTime);
        if (transform.position.y < limiteAbajo)
        {
            transform.position = new Vector3(transform.position.x, puntoInicial, 0f);
        }
    }
}
