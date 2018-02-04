using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// AL PULSAR ESC SE SALDRA DEL JUEGO
public class ExitGame : MonoBehaviour {
	// Update is called once per frame
	void Update ()
    {
        // LEE EL INPUT DEL ESC Y CIERRA LA APLICACION
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
