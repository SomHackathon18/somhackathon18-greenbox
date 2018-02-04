using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour {
    // AÑADIMOS EL ARCHIVO DE CARMOVEMENT PARA ACCEDER A SUS VARIABLES
    public CarMovement car1;
    public CarMovement car2;
    public CarMovement abuela;
    // AÑADIMOS EL ARCHIVO DE PlayerMovement PARA ACCEDER A SUS VARIABLES
    public PlayerMovement player;

	// Update is called once per frame
	void Update ()
    {
        // MECANICA DE GAME OVER
		if(car1.gameover ||car2.gameover)
        {
            resetball();
        }
	}
    public void resetball()
    {
        car1.Reset();
        car2.Reset();
        abuela.Reset();
        player.Reset();

        car1.gameover = false;
        car2.gameover = false;
    }
}
