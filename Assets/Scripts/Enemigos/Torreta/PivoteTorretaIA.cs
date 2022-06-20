using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivoteTorretaIA : MonoBehaviour
{
    [SerializeField] private bool puedeRotar;

    [Header("Distancia necesaria del jugador para rotar la torreta")]
    [Tooltip("determina que tanto debe estar alejado el jugador de la torreta,para que esta rote y dispare")]
    [SerializeField] private float distanciaMaxNecesaria;
    [SerializeField] private float distanciaMinNecesaria;

    [Header("Linkeos")]
    //[SerializeField] private GameObject objetivoPJ;
    [SerializeField] private SpawnTorreta1 spawnTorreta;
    //[SerializeField] private Rigidbody2D rb2DTorreta;//este linkeo al rigidbody de la torreta me servía para probar métodos que sirvan para rotar el rigidbody de la torreta.Por si al caso no sacarla por si se le ve un uso en el futuro.  

    private GameObject objetivoPJ;
    private void Start()
    {
        objetivoPJ = GameObject.Find("Jugador");
        //Debug.Log("La distancia entre la torreta y el jugador es:" + Vector3.Distance(objetivoPJ.transform.position, this.transform.position));
    }
    private void FixedUpdate()
    {
        GirarHaciaElObjetivo();
    }

    private void GirarHaciaElObjetivo()
    {
        if (Vector3.Distance(objetivoPJ.transform.position, this.transform.position) > distanciaMinNecesaria && Vector3.Distance(objetivoPJ.transform.position, this.transform.position) < distanciaMaxNecesaria)
        {
            puedeRotar = true;
            spawnTorreta.laTorretaEstaRotando = true;
        }
        else
        {
            puedeRotar = false;
            spawnTorreta.laTorretaEstaRotando = false;
        }
        if (puedeRotar)
        {
            Vector3 direccTorreta = transform.right;
            Vector3 direccObjetivo = objetivoPJ.transform.position - this.transform.position;
            float anguloAlQueGirar = Vector3.SignedAngle(direccTorreta, direccObjetivo, this.transform.forward);
            transform.Rotate(new Vector3(0f, 0f, anguloAlQueGirar));
        }
    }

}
