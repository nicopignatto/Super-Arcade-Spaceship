using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporizadorPrueba : MonoBehaviour//este temporizador se va a hacer con un "if" con un operador relacional ">" .No se puede hacer con el operador relacional "==";por que al no tener un valor muy exacto la var. "tiempoActual" no nos sirve dicho operador relacional.
{
    private float tiempoActual;
    [SerializeField] private float tiempoCouldown;
    void Start()
    {
        tiempoActual = 0;
        //tiempoActual = tiempoCouldown + 1;
    }

    void Update()
    {
        //Debug.Log(Time.time);
        //MostrarCartelTempCondFalsePrincipio();
        //MostrarCartelTempCondTruePrincipio();
        MostrarCartelMientrasSeMantieneBotonPresionado();
    }

    private void MostrarCartelTempCondFalsePrincipio()
    {
        /*if (tiempoActual > tiempoCouldown)
        {
            Debug.Log("estas listo para disparar");
        }
        else
        {
            Debug.Log("no estas listo para disparar");
        }*/
        if (Input.GetKey(KeyCode.Space))
        {
            if (tiempoActual > tiempoCouldown)
            {
                Debug.Log("estoy disparando");
                tiempoActual = 0;
            }
        }
        tiempoActual += Time.deltaTime;
    }

    private void MostrarCartelTempCondTruePrincipio()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (tiempoActual > tiempoCouldown)
            {
                Debug.Log("estoy disparando");
                tiempoActual = 0;
            }
        }
        tiempoActual += Time.deltaTime;
    }

    private void MostrarCartelMientrasSeMantieneBotonPresionado()//este metodo muestra un cartel por consola mientras se mantenga cierto tiempo presionada la tecla "espacio". 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (tiempoActual > tiempoCouldown)
            {
                Debug.Log("Habilidad disparada");
                tiempoActual = 0;
                Debug.Log("DESPUES DISPARAR LA HABILIDAD el tiempo actual es:" + tiempoActual);
            }
            /*else
            {
                Debug.Log("La habilidad todavia no esta cargada");
            }*/
            tiempoActual += Time.deltaTime;
        }
    }
}
