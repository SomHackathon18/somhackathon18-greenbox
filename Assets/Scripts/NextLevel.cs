using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// CAMBIAR A LA SIGUIENTE ESCENA CUANDO EL JUGADOR LLEGA A LA ZONA OBJETIVO
public class NextLevel : MonoBehaviour {
    // VARIABLE PARA PASAR DE NIVEL
    public ChangeScene changeScene;
    // VARIABLE PARA EL PLAYER
    public PlayerMovement player;
    public ResetGame resetgame;
    private void OnTriggerExit2D(Collider2D collision)
    {
        // CAMBIAR DE NIVEL
        if(collision.tag == "Player")
        {
            // SE AVANZA A LA SIGUIENTE ESCENA
            if(player.exit)
            {
                changeScene.NextLevel();
            }
            // SE REINICIA EL NIVEL YA QUE SE HA SALIDO DE LA ZONA DE JUEGO
            else
            {
                resetgame.resetball();
            }
        }
    }
}
