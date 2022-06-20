using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicReprodDisparosPJ : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private AudioSource audioSourceSonidoDisparoPJ;

    static private bool reproducirSonidoDisparoPJ;

    static public bool ReproducirSonidoDisparoPJ
    {
        get
        {
            return reproducirSonidoDisparoPJ;
        }

        set
        {
            reproducirSonidoDisparoPJ = value;
        }
    }

    private void Start()
    {
        reproducirSonidoDisparoPJ = false;
    }
    private void Update()
    {
        VerificarSiReproducirSonidoDisparoPJ();
    }

    private void VerificarSiReproducirSonidoDisparoPJ()
    {
        if (reproducirSonidoDisparoPJ == true)
        {
            reproducirSonidoDisparoPJ = false;
            audioSourceSonidoDisparoPJ.Play();
        }
    }
}
