using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicGameOver : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private GameObject panelGameOver;//esta variable hace referencia la panel Game Over que sirve para indicar cuando el jugador perdio.
    [SerializeField] private AudioSource musicaNivel;//se refiere al AudioSource que reproduce la musica de fondo del nivel actual.

    static private int cantVidasPJGameOver;

    static public int CantVidasPJGameOver
    {
        get
        {
            return cantVidasPJGameOver;
        }

        set
        {
            cantVidasPJGameOver = value;
        }
    }
    private void Start()
    {
        Time.timeScale = 1f;
        cantVidasPJGameOver = 1;
        panelGameOver.SetActive(false);
    }
    void Update()
    {
        
        
        if (cantVidasPJGameOver <= 0)
        {
            Time.timeScale = 0f;
            panelGameOver.SetActive(true);
            musicaNivel.volume = 0.20f;
        }
        
        
    }

    public void ReintentarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
