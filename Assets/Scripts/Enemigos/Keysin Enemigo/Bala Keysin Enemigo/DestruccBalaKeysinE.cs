using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccBalaKeysinE : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "jugador" || collision.gameObject.tag == "proyectil")
        {
            Destroy(this.gameObject);
        }
    }
}
