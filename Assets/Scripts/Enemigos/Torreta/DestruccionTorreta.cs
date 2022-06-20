using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionTorreta : MonoBehaviour
{
    [SerializeField] private bool meDestruyo;//este booleano sirve de bandera para determinar si se destruye o no la torreta cuando entra en colisión con un objeto con el tag "proyectil"
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "proyectil")
        {
            //Debug.Log("estoy colisionando con el proyectil del jugador");
            LogicRepExplosionesEnemigos.ReproducirSonidoExplosion = true;
            meDestruyo = true;
            DestruirTorreta();
        }
        else
        {
            meDestruyo = false;
            DestruirTorreta();
        }
    }
    private void DestruirTorreta()
    {
        if (meDestruyo == true)
        {
            gameObject.SetActive(false);
        }
    }
}
