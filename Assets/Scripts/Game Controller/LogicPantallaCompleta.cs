using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LogicPantallaCompleta : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private Toggle togglePantallaCompleta;

    private void Start()
    {
        togglePantallaCompleta.isOn = true;
    }

    public void CambiarAPantallaCompleta()
    {
        if (togglePantallaCompleta.isOn == true)
        {
            Screen.fullScreen = true;
            //Debug.Log("pantalla completa");
        }
        else
        {
            if (togglePantallaCompleta.isOn == false)
            {
                Screen.fullScreen = false;
               // Debug.Log("no hay pantalla completa");
            }
        }
    }
}
