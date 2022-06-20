using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GCMenuPausa : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private GameObject panelMenuPausa;
    [SerializeField] private GameObject panelOpciones;
    [SerializeField] private GameObject panelGameOver;
   
    private bool puedoReanudar;
    private void Start()
    {
        puedoReanudar = true;
        panelMenuPausa.SetActive(false);
        panelOpciones.SetActive(false);
    }

    private void Update()
    {
        ReanudarJuegoConTecla();
        
    }
    public void Reanudarjuego()
    {
        puedoReanudar = !puedoReanudar;

        if (puedoReanudar == true && panelGameOver.activeInHierarchy == false)
        {
            Time.timeScale = 1f;
            panelMenuPausa.SetActive(false);
        }
        else
        {
            if (puedoReanudar == false && panelGameOver.activeInHierarchy == false)
            {
                Time.timeScale = 0f;
                panelMenuPausa.SetActive(true);
            }
        }
    }

    private void ReanudarJuegoConTecla()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            puedoReanudar = !puedoReanudar;

            if (puedoReanudar == true && panelGameOver.activeInHierarchy == false)
            {
                Time.timeScale = 1f;
                panelMenuPausa.SetActive(false);
                panelOpciones.SetActive(false);
            }
            else
            {
                if (puedoReanudar == false && panelGameOver.activeInHierarchy == false)
                {
                    Time.timeScale = 0f;
                    panelMenuPausa.SetActive(true);
                    //Debug.Log("el menu pausa esta activado,siempre y cuando el panel Game Over no");
                }
            }
        }
    }

    public void IrAOpciones()
    {
        panelMenuPausa.SetActive(false);
        panelOpciones.SetActive(true);
    }

    public void VolverDeOpciones()
    {
        panelMenuPausa.SetActive(true);
        panelOpciones.SetActive(false);
    }
    public void IrAMenuPrincipal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu Inicio");

    }
}
