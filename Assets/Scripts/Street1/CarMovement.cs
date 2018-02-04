using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {
    // VELOCIDAD COCHE
    public float speed;
    // POSICION INICIAL DEL COCHE
    private Vector3 iniPos;
    // VARIABLE LOGICA DE DERROTA
    public bool gameover = false;
    // Use this for initialization
    protected virtual void Awake ()
    {
        // INICIALIZAMOS LA POSICION INICIAL DEL COCHE
        iniPos = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        // MOVIMIENTO DEL COCHE
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        // EN CASO DE SALIR DE LA PANTALLA DE JUEGO SE RESETEA EN SU POSICION INICIAL PARA VOLVER A PASAR
        if (collision.tag == "Background")
        {
            Reset();
        }
    }
    // COLISION ENTRE COCHES PARA EVITAR BUGS DE QUE ESTEN SOLAPADOS VARIOS COCHES
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "CarDown")
        {
            Reset();
        }
        if (collision.gameObject.tag == "Player")
        {
            gameover = true;
        }
    }

    // METODO PARA RESETEAR POSICION
    public void Reset()
    {
        transform.position = iniPos;
    }
}
