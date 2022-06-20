using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicReprodDisparoTorretaE : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private AudioSource audioSourceSonidoDisparoTorretaE;

    static private bool reproducirSonidoDisparoTorretaE;

    static public bool ReproducirSonidoDisparoTorretaE
    {
        get
        {
            return reproducirSonidoDisparoTorretaE;
        }

        set
        {
            reproducirSonidoDisparoTorretaE = value;
        }
    }

    private void Start()
    {
        reproducirSonidoDisparoTorretaE = false;
    }

    private void Update()
    {
        VerificarSiReprodSonidoDisparoTorretaE();
    }

    private void VerificarSiReprodSonidoDisparoTorretaE()
    {
        if (reproducirSonidoDisparoTorretaE == true)
        {
            reproducirSonidoDisparoTorretaE = false;
            audioSourceSonidoDisparoTorretaE.Play();
        }
    }
}
