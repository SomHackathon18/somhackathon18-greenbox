using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameS2 : MonoBehaviour {
    // AÑADIMOS EL ARCHIVO DE CARMOVEMENT PARA ACCEDER A SUS VARIABLES
    public CarMovementS2 car1;
    public CarMovement2S2 car2;
    public CarMovementS2 car3;
    public CarMovement2S2 car4;
    // AÑADIMOS EL ARCHIVO DE PlayerMovement PARA ACCEDER A SUS VARIABLES
    public PlayerMovement player;

	// Update is called once per frame
	void Update ()
    {
        if (car1.gameover || car2.gameover || car3.gameover || car3.gameover)
        {
            resetall();
        }
    }
    public void resetall()
    {
        car1.Reset();
        car2.Reset();
        car3.Reset();
        car4.Reset();
        player.Reset();

        car1.gameover = false;
        car2.gameover = false;
        car3.gameover = false;
        car4.gameover = false;
    }
}
