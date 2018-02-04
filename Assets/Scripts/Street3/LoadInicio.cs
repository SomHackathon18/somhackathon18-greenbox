using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadInicio : MonoBehaviour {
    // INICIALIZAR EL COMPONENTE PlayerMovement PARA USAR SUS PROPIEDADES
    public PlayerMovement player;
    // INICIALIZAR EL COMPONENTE ResetGameS3 PARA USAR SUS PROPIEDADES
    public ResetGameS3 resetgame;
     
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // SE PASA AL MENU INICIAL PARA VOLVER A EMPEZAR
            if (player.exit)
            {
                SceneManager.LoadScene("inicio");
            }
            // SE RESETEA EL NIVEL YA QUE EL JUGADOR HA SALIDO DE LA ZONA DE JUEGO
            else
            {
                resetgame.resetall();
            }
        }
    }
}
