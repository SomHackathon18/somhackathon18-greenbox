using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    // CONTADOR PARA CARGAR LA SIGUIENTE ESCENA
    private float contador = 0;

	// Update is called once per frame
	void Update ()
    {
        contador += Time.deltaTime;
        if (contador >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
