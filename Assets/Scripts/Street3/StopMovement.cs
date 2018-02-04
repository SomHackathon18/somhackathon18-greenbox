using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMovement : MonoBehaviour {
    // INICIALIZAMOS LOS COMPONENTES DE LOS VEHICULOS PARA ACCEDER A SUS PROPIEDADES
    public CarMovementS2 car1;
    public CarMovementS2 car2;
    // INICIALIZAMOS EL COMPONENTE DEL SEMAFORO PARA ACCEDER A SUS PROPIEDADES
    public semaforo semaforo;

    private void Update()
    {
        // REANUDAR MOVIMIENTO DE LOS VEHICULOS
        if (!semaforo.stop)
        {
            car1.stop = false;
            car2.stop = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // DETENER MOVIMIENTO DE LOS VEHICULOS
        if (semaforo.stop)
        {
            if (collision.tag == "CarDown")
            {
                car1.stop = true;
            }
            if (collision.tag == "CarTop")
            {
                car2.stop = true;
            }
        }
        
    }
}
