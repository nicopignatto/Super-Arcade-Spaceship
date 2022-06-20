using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicRepExplosionesEnemigos : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private AudioSource audioSourceExplosionesE;
    static private bool reproducirSonidoExplosion;
    static public bool ReproducirSonidoExplosion
    {
        get
        {
            return reproducirSonidoExplosion;
        }
        set
        {
            reproducirSonidoExplosion = value;
        }
    }

    private void Start()
    {
        reproducirSonidoExplosion = false;
    }

    private void Update()
    {
        VerificarSiReproducirSonido();
    }

    private void VerificarSiReproducirSonido()
    {
        if (reproducirSonidoExplosion==true)
        {
            reproducirSonidoExplosion = false;
            audioSourceExplosionesE.Play();
        }
    }
}
