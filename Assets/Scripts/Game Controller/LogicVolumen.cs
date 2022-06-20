using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicVolumen : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private Slider sliderVolumenSonidoGeneral;
    [SerializeField] private List<AudioSource> reproductoresSonido;//en esta lista vamos a agrupar todos los objetos con audio source.
    [SerializeField] private Image imagenParlanteSilenciado;
    private void Start()
    {
        sliderVolumenSonidoGeneral.value = PlayerPrefs.GetFloat("volumen general", 0.5f);
        for (int i = 0; i <reproductoresSonido.Count ; i++)
        {
            reproductoresSonido[i].volume = sliderVolumenSonidoGeneral.value;

        }
    }
    public void CambiarVolumen()
    {
        for (int i = 0; i <reproductoresSonido.Count; i++)
        {
            reproductoresSonido[i].volume = sliderVolumenSonidoGeneral.value;
        }
        
        PlayerPrefs.SetFloat("volumen general", sliderVolumenSonidoGeneral.value);
        if (sliderVolumenSonidoGeneral.value == 0)
        {
            imagenParlanteSilenciado.enabled = true;
        }
        else
        {
            imagenParlanteSilenciado.enabled = false;
        }
    }
}
