using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicReconstruirCañonTorreta : MonoBehaviour
{
    private GameObject objetoJugador;//esta variable hace referencia al objeto "Jugador",que es jugable por el usuario.

    [Header("Linkeos")]
    [SerializeField] private float distanciaNecesaria;/*esta variable hace referencia a la cantidad de distancia que debe estar el objeto "Jugador" de la base torreta,para
    que esta se reconstruya.*/
    [SerializeField] private GameObject objetoCañonTorreta;

    private void Start()
    {
        objetoJugador = GameObject.Find("Jugador");
        
        //Debug.Log(gameObject.activeInHierarchy);
        //Debug.Log(Vector3.Distance(this.transform.position, objetoJugador.transform.position));
    }

    private void Update()
    {
        //Debug.Log(Vector3.Distance(this.transform.position, objetoJugador.transform.position));
        ReactivarTorreta();
    }

    private void ReactivarTorreta()
    {
        if (Vector3.Distance(this.transform.position, objetoJugador.transform.position) > distanciaNecesaria)
        {
            objetoCañonTorreta.SetActive(true);
        }
    }
}
