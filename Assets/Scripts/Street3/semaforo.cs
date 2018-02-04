using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaforo : MonoBehaviour {
    // GAMEOBJECTS PARA LAS LUCES DEL SEMAFORO
    public GameObject luzroja;
    public GameObject luzverde;
    // GAMEOBJECT DEL BOTON DE INTERACCION CON EL SEMAFORO
    public GameObject boton;
    // BOOLEANO PARA DETENER EL MOVIMIENTO DE LOS VEHICULOS
    public bool stop = false;
    // BOOLEANO PARA MEDIR EL TEMPORIZADOR DEL SEMAFORO
    private bool temp = false;
    // CONTADOR PARA EL SEMAFORO
    public float contador = 0;
	// Update is called once per frame
	void Update ()
    {
        // MOVIMIENTO DE LOS VEHICULOS
        if (!stop) 
        {
            luzroja.SetActive(true);
            luzverde.SetActive(false);
        }
        // VEHICULOS PARADOS
        if (stop) 
        {
            luzroja.SetActive(false);
            luzverde.SetActive(true);
            contador += Time.deltaTime;
            // DURACION LUZ VERDE
            if (contador >= 8) 
            {
                stop = false;
                contador = 0;
            }
        }
        // TEMPORIZADOR PARA LAS LUCES DEL SEMAFORO
        if(temp)
        {
            contador += Time.deltaTime;
            // DURACION LUZ ROJA
            if (contador >= 5)
            {
                stop = true;
                temp = false;
                contador = 0;
            }
        }
	}
    // INTERACCION CON EL SEMAFORO
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKey(KeyCode.F))
        {
            temp = true;
        }
    }
    // MOSTRAR BOTON DEL TECLADO
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            boton.SetActive(true);
        }
    }
    // OCULTAR BOTON DEL TECLADO
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            boton.SetActive(false);
        }
    }

}
