using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicVidaMuertePJ : MonoBehaviour
{
    [Header("Cantidad de vidas del jugador")]
    [SerializeField] private float cantVidasPJ;
    [SerializeField] private float dañoPorCol;//esta variable determina cuanto daño va a recebir por colisionae con enemigos/proyectiles enemigos.

    [Header("Linkeos")]
    [SerializeField] private List<GameObject> listaVidas;

    //private bool colisioneConObjetoEnemigo;
    /*private void Start()
    {
        colisioneConObjetoEnemigo = false;
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo")||collision.gameObject.CompareTag("torreta enemiga")||collision.gameObject.CompareTag("proyectil enemigo"))
        {
            //colisioneConObjetoEnemigo = true;
            cantVidasPJ -= dañoPorCol;
            RestarVidasPjUI();
            MuertePJ();//este metodo despues tenes q modificarlo pero por ahora dejalo.
            
        }
    }


    private void RestarVidasPjUI()
    {
            switch (cantVidasPJ)
            {
                case 4:
                    listaVidas[4].SetActive(false);
                    break;
                case 3:
                    listaVidas[3].SetActive(false);
                    break;
                case 2:
                    listaVidas[2].SetActive(false);
                    break;
                case 1:
                    listaVidas[1].SetActive(false);
                    break;
                case 0:
                    listaVidas[0].SetActive(false);
                    break;
                default:
                
                    break;
            }
        
    }

    private void MuertePJ()//este metodo sirve para reiniciar el nivel por si el jugador pierde.
    {
        if (cantVidasPJ <= 0)
        {
            LogicGameOver.CantVidasPJGameOver = 0;
        }
    }
}
