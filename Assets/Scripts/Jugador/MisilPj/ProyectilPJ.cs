using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProyectilPJ : MonoBehaviour
{
    [Header("Velocidad proyectil")]
    [SerializeField] private float velProyectil;

    [Header("Tiempo antes de destruirse despues de ser instanciado el objeto")]
    [SerializeField] private float tiempoDestruccion;

    [Header("Linkeos")]
    [SerializeField] private Rigidbody2D rb2DProyectil;

    

    private void Start()
    {
        Destroy(this.gameObject, tiempoDestruccion);
        
    }
    private void FixedUpdate()
    {
        MovProyectil();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("proyectil enemigo") || collision.gameObject.CompareTag("enemigo")||collision.gameObject.CompareTag("torreta enemiga"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("enemigo") || collision.gameObject.CompareTag("torreta enemiga"))
        {
            LogicPasarNivel.SumoMuertesEnemigos = true;
            LogicPuntosPJ.SumoPuntos = true;
            
        }
    
    }

    private void MovProyectil()
    {
        rb2DProyectil.velocity = Vector2.up * velProyectil * Time.fixedDeltaTime;
    }
}
