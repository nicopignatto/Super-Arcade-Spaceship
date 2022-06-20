using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicCreditos : MonoBehaviour
{
    [Header("Tiempo antes de ir al menu principal")]
    [SerializeField] private float tiempoDuracionCreditos;//esta variable hace ref. a cuánto tiempo tardan los créditos en pasar antes de volver al menu principal.

    [Header("Tiempo antes de que aparezca la indicación 'Omitir'")]
    [SerializeField] private float tiempoAparicionOmitir;//esta variable hace ref. al tiempo que debe pasar antes de mostrar la indicación de "Omitir Creditos".

    [Header("Linkeos")]
    [SerializeField] private GameObject textoOmitir;//esta variable hace ref. al texto en pantalla,que dice:"omitir('Space')". 

    private void Start()
    {
        textoOmitir.SetActive(false);
    }
    private void Update()
    {
        OmitirCreditosConTecla();
        Invoke("ActivarTextoOmitir", tiempoAparicionOmitir);
        Invoke("IrAMenuPrincipal", tiempoDuracionCreditos);
    }

    private void ActivarTextoOmitir()
    {
        textoOmitir.SetActive(true);
    }

    private void OmitirCreditosConTecla()
    {
        if (Input.GetKeyDown(KeyCode.Space) && textoOmitir.activeInHierarchy == true)
        {
            SceneManager.LoadScene("Menu Inicio");
        }
    }

    private void IrAMenuPrincipal()
    {
        SceneManager.LoadScene("Menu Inicio");
    }
}
