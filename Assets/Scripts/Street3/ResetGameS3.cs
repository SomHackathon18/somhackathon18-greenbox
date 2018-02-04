using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameS3 : MonoBehaviour {
    // AÑADIMOS EL ARCHIVO DE CARMOVEMENT PARA ACCEDER A SUS VARIABLES
    public CarMovementS2 car1;
    public CarMovementS2 car2;
    // AÑADIMOS EL ARCHIVO DE PlayerMovement PARA ACCEDER A SUS VARIABLES
    public PlayerMovement player;

	// Update is called once per frame
	void Update ()
    {
        if (car1.gameover || car2.gameover)
        {
            resetall();
        }
    }
    public void resetall()
    {
        car1.Reset();
        car2.Reset();
        player.Reset();

        car1.gameover = false;
        car2.gameover = false;
    }
}
