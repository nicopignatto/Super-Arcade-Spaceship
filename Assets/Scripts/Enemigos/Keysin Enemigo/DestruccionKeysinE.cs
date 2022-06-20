using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionKeysinE : MonoBehaviour
{
    private GameObject objPadre;
    private void Start()
    {
        objPadre = transform.parent.gameObject;//acá se hace referencia al objeto padre del enemigo keysin.
    }

    private void Update()
    {
        //Debug.Log(Vector3.Distance(objPadre.transform.position,sensorParaMedirDistDeDestruccE.transform.position));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("proyectil"))
        {
            LogicRepExplosionesEnemigos.ReproducirSonidoExplosion = true;
            /*Debug.Log("colisione con" + " " + collision.gameObject.tag);*/
            // Destroy(this.transform.parent);//este codigo no se usa para lo que se necesita,pero lo dejamos para poder ver el error. 
            //Destroy(transform.parent.gameObject);//esta linea sirve para destruir el objeto padre del enemigo keysin.
            Destroy(objPadre);//esta linea hace lo mismo que la de arriba.Osea destruye el objeto padre del enemigo keysin. 

        }
    }
   
}
