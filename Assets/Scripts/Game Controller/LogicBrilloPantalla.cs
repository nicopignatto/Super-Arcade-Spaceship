using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicBrilloPantalla : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private Slider sliderBrillo;
    [SerializeField] private Image imagenPanelBrillo;

    private void Start()
    {
        sliderBrillo.value = PlayerPrefs.GetFloat("valor general brillo", 0f);
        imagenPanelBrillo.color = new Color(imagenPanelBrillo.color.r, imagenPanelBrillo.color.g, imagenPanelBrillo.color.b, sliderBrillo.value);
    }
    public void CambiarBrillo()
    {
        imagenPanelBrillo.color = new Color(imagenPanelBrillo.color.r, imagenPanelBrillo.color.g, imagenPanelBrillo.color.b, sliderBrillo.value);
        PlayerPrefs.SetFloat("valor general brillo", sliderBrillo.value);
    }
}
