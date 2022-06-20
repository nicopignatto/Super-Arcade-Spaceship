using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicPuntosPJ : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private Text textoPuntajeNumericoPJ;

    [Header("Puntaje Actual del PJ")]
    [SerializeField] private float puntajeActualPJ;

    [Header("Puntos que el PJ suma cuando mata enemigos")]
    [SerializeField] private float cantPuntosPJ;//esta variable hace referencia a la cantidad de puntos del jugador cuando mata a un enemigo.
    
    static private bool sumoPuntos = false;

    static public bool SumoPuntos
    {
        get
        {
            return sumoPuntos;
        }
        set
        {
            sumoPuntos = value;
        }
    }

    private void Start()
    {
        puntajeActualPJ = 0f;
        textoPuntajeNumericoPJ.text = puntajeActualPJ.ToString();
    }
    private void Update()
    {
        SumarPuntajePJ();
    }

    private void SumarPuntajePJ()
    {
        if (sumoPuntos == true)
        {
            puntajeActualPJ += cantPuntosPJ;
            textoPuntajeNumericoPJ.text = puntajeActualPJ.ToString();
            sumoPuntos = false;
        }
    }
}
