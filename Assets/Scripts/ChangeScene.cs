using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// ARCHIVO PARA CAMBIAR DE ESCENA/NIVEL
public class ChangeScene : MonoBehaviour {

	public void NextLevel()
    {
        // CARGAR LA SIGUIENTE ESCENA
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
