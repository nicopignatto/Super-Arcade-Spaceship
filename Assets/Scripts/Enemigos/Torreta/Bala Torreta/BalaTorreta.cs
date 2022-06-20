using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaTorreta : MonoBehaviour
{
    [Header("Velocidad del proyectil enemigo")]
    [SerializeField] private float velProyectil;

    [Header("Tiempo antes de que se destruya el proyectil de la torreta enemiga")]
    [SerializeField] private float tiempoDestruccProyectilTorreta;
    
    [Header("Linkeos")]
    [SerializeField] private Rigidbody2D rb2DProyectilEnemigo;
    
    //esta variable sirve para referenciar al objetivo(jugador)
    private GameObject objetivoJugador;

    //estas variables de vectores sirven para determinar la direccion del proyectil de la torreta
    private Vector3 posJugador;
    private Vector3 posProyectil;
    private Vector3 direccDelObjetivo;

    //estas variables sirven para determinar la rotación del proyectil del proyectil de la torreta
    private Vector3 direccProyectil;
    private Vector3 direccObjetivo;
    private float anguloRotacionAObj;
    private void Start()
    {
        objetivoJugador = GameObject.Find("Jugador");
        posJugador = objetivoJugador.transform.position;
        posProyectil = this.transform.position;
        direccDelObjetivo = posJugador - posProyectil;
        direccProyectil = this.transform.right;
        direccObjetivo = objetivoJugador.transform.position - this.transform.position;
        anguloRotacionAObj = Vector3.SignedAngle(direccProyectil, direccObjetivo, this.transform.forward);
        RotarHaciaObjetivo();
        Destroy(this.gameObject, tiempoDestruccProyectilTorreta);
        
    }
    private void FixedUpdate()
    {
        MovProyectilEnemigo();
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "jugador" || collision.gameObject.tag == "proyectil" || collision.gameObject.CompareTag("enemigo") || collision.gameObject.CompareTag("proyectil enemigo"))
        {
            //Debug.Log(collision.gameObject.tag);
            gameObject.SetActive(false);
        }
    }
    private void MovProyectilEnemigo()
    {
        rb2DProyectilEnemigo.velocity = direccDelObjetivo.normalized * velProyectil * Time.fixedDeltaTime;
    }
    
    //este metodo sirve para desactivar el objeto aunque ahora esta sin uso pero por lo menos ya esta definido para usarlo cuando se desee
    private void DesactivarObjeto()
    {
        Debug.Log("Se desactiva la bala");
        this.gameObject.SetActive(false);
    }

    private void RotarHaciaObjetivo()
    {
        //estas lineas sirven para la rotacion del protectil de la torreta

        //this.transform.Rotate(new Vector3(0f, 0f, anguloRotacionAObj));
        //this.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, anguloRotacionAObj));
        //rb2DProyectilEnemigo.MoveRotation(anguloRotacionAObj);
        rb2DProyectilEnemigo.rotation = anguloRotacionAObj;
    }
    

}
