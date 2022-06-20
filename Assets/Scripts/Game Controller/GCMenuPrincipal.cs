using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GCMenuPrincipal : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private GameObject panelMenuPrincipal;
    [SerializeField] private GameObject panelOpciones;

    private void Start()
    {
        panelMenuPrincipal.SetActive(true);
        panelOpciones.SetActive(false);
    }
    private void Update()
    {
        VolverDeOpcionesConTecla();
    }
    public void IniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void CargarOpciones()
    {
        panelMenuPrincipal.SetActive(false);
        panelOpciones.SetActive(true);
    }
    public void SalirDelJuego()
    {
        Application.Quit();
    }
    private void VolverDeOpcionesConTecla() //este metodo sirve para volver de las "opciones" al "menu principal" con la tecla "esc"
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelMenuPrincipal.SetActive(true);
            panelOpciones.SetActive(false);
        }
    }
}
