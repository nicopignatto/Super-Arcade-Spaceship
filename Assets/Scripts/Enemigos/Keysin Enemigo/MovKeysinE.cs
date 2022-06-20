using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovKeysinE : MonoBehaviour
{
    [Header("Velocidad de mov. del enemigo")]
    [Range(325f,405f)]
    [SerializeField] private float velEnemigo;

    [Space]

    [Header("Límites de movimiento en escenario")]
    [SerializeField] private float limiteIzq;
    [SerializeField] private float limiteDer;

    [Space]

    [Header("Linkeos")]
    [SerializeField] private Rigidbody2D rb2DEnemigo;
    
    private bool izquierda;
    private void Start()
    {
        izquierda = false;
    }
    private void FixedUpdate()
    {
        MovDelEnemigo();
    }

    private void MovDelEnemigo()
    {
        if (transform.position.x > limiteDer)
        {
            izquierda = true;
        }

        if (transform.position.x < limiteIzq)
        {
            izquierda = false;
        }

        if (izquierda == true)
        {
            rb2DEnemigo.velocity = new Vector2(-velEnemigo * Time.fixedDeltaTime, 0f);
        }

        if (izquierda==false)
        {
            rb2DEnemigo.velocity = new Vector2(velEnemigo * Time.fixedDeltaTime, 0f);
        }
    }
}
