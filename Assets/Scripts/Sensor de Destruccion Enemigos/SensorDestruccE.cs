using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorDestruccE : MonoBehaviour
{
   
    [SerializeField] private GameObject objEnemigoK;
    /*private void Start()
    {
        objEnemigoK = GameObject.Find("EnemigoKeysin").gameObject;
        Debug.Log(objEnemigoK.name);
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            //Debug.Log("la nave enemiga se destruye");
            Destroy(collision.transform.parent.gameObject);
        }

        if (collision.gameObject.tag == "proyectil enemigo")
        {
            Destroy(collision.gameObject);
        }
    }
}