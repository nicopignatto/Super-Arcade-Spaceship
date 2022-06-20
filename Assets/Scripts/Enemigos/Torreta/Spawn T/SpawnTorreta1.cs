using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTorreta1 : MonoBehaviour
{
    [Header("Booleano que determina si la torreta esta girando")]
    public bool laTorretaEstaRotando;

    [Header("Tiempo entre disparos de la Torreta Enemiga")]
    [SerializeField] private float tiempoEntreDisparosTorreta;
    private float tiempoActual;
   
    [Header("Linkeos")]
    [SerializeField] private GameObject balaTorreta;
  
    
    //private bool disparar;
    private void Start()
    {
        tiempoActual = tiempoEntreDisparosTorreta + 1;
        laTorretaEstaRotando = false;
    }
    private void Update()
    {
        SpawnearBalaTorretaTemp();
        /*Invoke("PuedeDispararLaBala", couldown);
        Debug.Log("ya puede disparar de nuevo??" + " " + disparar);*/
    }

    

    private void SpawnearBalaTorretaTemp()//este metodo sirve para que la torreta dispare cuando esta rotando y con cierto tiempo entre disparos.
    {
        if (laTorretaEstaRotando == true)
        {
            if (tiempoActual > tiempoEntreDisparosTorreta)
            {
                LogicReprodDisparoTorretaE.ReproducirSonidoDisparoTorretaE = true;
                Instantiate(balaTorreta, this.transform.position, balaTorreta.transform.rotation);
                //Debug.Log("Torreta dispara");
                tiempoActual = 0;
                //Debug.Log("TIEMPO ACTUAL despues del disparo de la torreta:" + tiempoActual);
            }
        }
        tiempoActual += Time.deltaTime;
    }
}