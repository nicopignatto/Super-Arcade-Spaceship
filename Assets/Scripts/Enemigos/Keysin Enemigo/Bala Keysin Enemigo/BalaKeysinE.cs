using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaKeysinE : MonoBehaviour
{
    [Header("Velocidad del Proyectil de la Nave Keysin")]
    [SerializeField] private float velProyectilKeysinE;

    [Header("Tiempo antes destruirse la bala del Enemigo Keysin")]
    [SerializeField] private float tiempoDestrucc;

    [Header("Linkeos")]
    [SerializeField] private Rigidbody2D rb2D;

    private void Start()
    {
        Destroy(this.gameObject, tiempoDestrucc);
    }
    private void FixedUpdate()
    {
        MovBalaKeysinE();
    }

    private void MovBalaKeysinE()
    {
        rb2D.velocity = Vector2.down.normalized * velProyectilKeysinE * Time.fixedDeltaTime;
    }
}
