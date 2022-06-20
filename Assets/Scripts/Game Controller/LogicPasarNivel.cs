using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicPasarNivel : MonoBehaviour
{
    [Header("número de bajas enemigas para pasar al siguiente nivel del juego")]
    [SerializeField] private float cantNecesariaBajasE;//esta variable hace ref. a la cant. de enemigos que el PJ debe derrotar para pasar al ste. nivel del juego.

    static private float contadorMuerteEnemigos;
    static private bool sumoMuertesEnemigos;

    static public bool SumoMuertesEnemigos
    {
        get
        {
            return sumoMuertesEnemigos;
        }

        set
        {
            sumoMuertesEnemigos = value;
        }
    }

    
    private void Start()
    {
        sumoMuertesEnemigos = false;
        contadorMuerteEnemigos = 0f;
    }

    private void Update()
    {
        PasarAlSiguienteNivel();
        //Debug.Log("Cantidad de muertes enemigas: " + contadorMuerteEnemigos);
    }

    private void PasarAlSiguienteNivel()
    {
        if (sumoMuertesEnemigos == true)
        {
            sumoMuertesEnemigos = false;
            contadorMuerteEnemigos += 1;
            if (contadorMuerteEnemigos == cantNecesariaBajasE)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
    }
}
