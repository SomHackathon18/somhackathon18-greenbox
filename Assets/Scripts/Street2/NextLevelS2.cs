using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelS2 : MonoBehaviour {
    // VARIABLE PARA PASAR DE NIVEL
    public ChangeScene changeScene;
    // VARIABLE PARA EL PLAYER
    public PlayerMovement player;
    public ResetGameS2 resetgame;
    private void OnTriggerExit2D(Collider2D collision)
    {
        // CAMBIAR DE NIVEL
        if(collision.tag == "Player")
        {
            if(player.exit)
            {
                changeScene.NextLevel();
            }
            else
            {
                resetgame.resetall();
            }
        }
    }
}
