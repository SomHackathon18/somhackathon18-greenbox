using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParadaS2 : MonoBehaviour {
    // VARIABLE PARA EL COCHE 1
    public CarMovementS2 car1;
    public CarMovementS2 car2;

    private float contador = 0;
    private float contador2 = 0;
    // Update is called once per frame
    void Update ()
    {
		if(car1.stop)
        {
            contador += Time.deltaTime;
            if(contador >= 4)
            {
                car1.stop = false;
                contador = 0;
            }
        }
        if (car2.stop)
        {
            contador2 += Time.deltaTime;
            if (contador2 >= 4)
            {
                car2.stop = false;
                contador2 = 0;
            }
        }
    }
    // AL COLISIONAR LOS VEHICULOS CON EL SENSOR DE PARADA SE DETENDRAN
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "CarDown")
        {
            car1.stop = true; 
        }
        if (collision.tag == "CarTop")
        {
            car2.stop = true;
        }
    }
}
