using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Header("Velocidad del jugador")]
    [SerializeField] private float vel;

    [Space]

    /*[Header("Teclas de movimiento")]
    [SerializeField] private KeyCode teclaIzq;
    [SerializeField] private KeyCode teclaDer;
    [SerializeField] private KeyCode teclaArriba;
    [SerializeField] private KeyCode teclaAbajo;*/

    [Space]

    [Header("Límites del mov.")]
    [SerializeField] private float limiteIzq;
    [SerializeField] private float limiteDer;
    [SerializeField] private float limiteArriba;
    [SerializeField] private float limiteAbajo;

    [Space]

    [Header("Linkeos")]
    [SerializeField] private Rigidbody2D rb2D;

    private float inputHorizontal;
    private float inputVertical;
    private void FixedUpdate()
    {
        Mov();
        
    }

    private void Mov()
    {
        /*if (Input.GetKey(teclaIzq))
        {
            if (transform.position.x > limiteIzq)
            {
                rb2D.velocity = new Vector2(-vel * Time.fixedDeltaTime, rb2D.velocity.y);
            }
            
        }
        else
        {
            if (Input.GetKey(teclaDer))
            {
                if (transform.position.x < limiteDer)
                {
                    rb2D.velocity = new Vector2(vel * Time.fixedDeltaTime, rb2D.velocity.y);
                }
               
            }
            else
            {
                if (Input.GetKey(teclaArriba))
                {
                    if (transform.position.y < limiteArriba)
                    {
                        rb2D.velocity = new Vector2(rb2D.velocity.x, vel * Time.fixedDeltaTime);
                    }
                   
                }
                else
                {
                    if (Input.GetKey(teclaAbajo))
                    {
                        if (transform.position.y > limiteAbajo)
                        {
                            rb2D.velocity = new Vector2(rb2D.velocity.x, -vel * Time.fixedDeltaTime);
                        }
                       
                    }
                    else
                    {
                        rb2D.velocity = new Vector2(0f, 0f);
                    }
                }
            }
        }

        if (transform.position.x < limiteIzq)
        {
            rb2D.position = new Vector2(limiteIzq, transform.position.y);
            rb2D.velocity = new Vector2(0f, 0f);
        }

        if (transform.position.x > limiteDer)
        {
            rb2D.position = new Vector2(limiteDer, transform.position.y);
            rb2D.velocity = new Vector2(0f, 0f);
        }

        if (transform.position.y > limiteArriba)
        {
            rb2D.position = new Vector2(transform.position.x, limiteArriba);
            rb2D.velocity = new Vector2(0f, 0f);
        }

        if (transform.position.y < limiteAbajo)
        {
            rb2D.position = new Vector2(transform.position.x, limiteAbajo);
            rb2D.velocity = new Vector2(0f, 0f);
        }*/

        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");

        rb2D.velocity = new Vector2(inputHorizontal * vel * Time.fixedDeltaTime, rb2D.velocity.y);
        rb2D.velocity = new Vector2(rb2D.velocity.x, inputVertical * vel * Time.fixedDeltaTime);

        if (transform.position.x < limiteIzq)
        {
            rb2D.position = new Vector2(limiteIzq, transform.position.y);
            //rb2D.velocity = Vector2.zero;
        }

        if (transform.position.x > limiteDer)
        {
            rb2D.position = new Vector2(limiteDer, transform.position.y);
            //rb2D.velocity = Vector2.zero;
        }

        if (transform.position.y > limiteArriba)
        {
            rb2D.position = new Vector2(transform.position.x, limiteArriba);
            //rb2D.velocity = Vector2.zero;
        }

        if (transform.position.y < limiteAbajo)
        {
            rb2D.position = new Vector2(transform.position.x, limiteAbajo);
            //rb2D.velocity = Vector2.zero;
        }
    }
}