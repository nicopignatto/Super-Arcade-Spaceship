using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicVolumenMudo : MonoBehaviour
{
    //private int valorVerdadToggleAudio;
    /*esta variable servia para seguir una logica y guardar el valor del toggle por medio de un integer que es el tipo de dato
    de esta variable justamente*/

    [Header("Linkeos")]
    [SerializeField] private List<AudioSource> listaReprSonido;
    [SerializeField] private Toggle toggleAudioAct;

    private void Start()
    {
        toggleAudioAct.isOn = false;

        if (toggleAudioAct.isOn == true)
        {
            for (int i = 0; i < listaReprSonido.Count; i++)
            {
                listaReprSonido[i].mute = true;
            }
        }
        else
        {
            if (toggleAudioAct.isOn == false)
            {
                for (int i = 0; i < listaReprSonido.Count; i++)
                {
                    listaReprSonido[i].mute = false;
                }
            }
        }
    }

    public void SilenciarAudioJuego()
    {
        if (toggleAudioAct.isOn == true)
        {
            for (int i = 0; i < listaReprSonido.Count; i++)
            {
                listaReprSonido[i].mute = true;
            }
        }
        else
        {
            if (toggleAudioAct.isOn == false)
            {
                for (int i = 0; i < listaReprSonido.Count; i++)
                {
                    listaReprSonido[i].mute = false;
                }
            }
        }
    }
}
