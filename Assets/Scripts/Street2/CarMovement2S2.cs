using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement2S2 : MonoBehaviour {
    // VELOCIDAD COCHE
    public float speed;
    // POSICION INICIAL DEL COCHE
    private Vector3 iniPos;
    // VARIABLE LOGICA DE DERROTA
    public bool gameover = false;
    // BOOLEANO PARA LA PARADA DEL COCHE
    public bool stop = false;
    // TEMPORIZADOR PARA EMPEZAR LA MARCHA
    private float start = 0;
    // Use this for initialization
    protected virtual void Awake ()
    {
        // INICIALIZAMOS LA POSICION INICIAL DEL COCHE
        iniPos = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        start += Time.deltaTime;
        if(!stop && start >= 2)
        {
            // MOVIMIENTO DEL COCHE
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
	}

    // COLISION ENTRE COCHES PARA EVITAR BUGS DE QUE ESTEN SOLAPADOS VARIOS COCHES
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameover = true;
        }
        if(collision.gameObject.tag == "CarDown" || collision.gameObject.tag == "CarTop")
        {
            stop = true;
        }
    }
    // AL DEJAR DE COLISIONAR VUELVE A AVANZAR
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CarDown" || collision.gameObject.tag == "CarTop")
        {
            stop = false;
        }
    }
    // AL SALIR DE LA ZONA DE JUEGO SE REINICIA SU POSICION
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Background")
        {
            Reset();
        }
    }

    // METODO PARA RESETEAR POSICION
    public void Reset()
    {
        transform.position = iniPos;
        start = 0;
    }
}
