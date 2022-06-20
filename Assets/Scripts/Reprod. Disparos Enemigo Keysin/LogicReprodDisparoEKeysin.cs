using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicReprodDisparoEKeysin : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private AudioSource audioSourceSonidoDisparoEKeysin;

    static private bool reproducirSonidoDisparoEKeysin;

    static public bool ReproducirSonidoDisparoEKeysin
    {
        get
        {
            return reproducirSonidoDisparoEKeysin;
        }

        set
        {
            reproducirSonidoDisparoEKeysin = value;
        }
    }


    private void Start()
    {
        reproducirSonidoDisparoEKeysin = false;
    }

    private void Update()
    {
        VerificarSiReprodSonidoDisparoEKeysin();
    }

    private void VerificarSiReprodSonidoDisparoEKeysin()
    {
        if (reproducirSonidoDisparoEKeysin == true)
        {
            reproducirSonidoDisparoEKeysin = false;
            audioSourceSonidoDisparoEKeysin.Play();
        }
    }
}
