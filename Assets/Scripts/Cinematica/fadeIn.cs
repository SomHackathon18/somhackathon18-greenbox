using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeIn : MonoBehaviour {
    // ESTABLECER VARIABLE DEL SPRITE
    public SpriteRenderer sprite;
    public SpriteRenderer sprite2;
    // VELOCIDAD DE FUNDIDO DEL SPRITE
    private float alpha = 0.4f;
    //CONTADOR PARA SEGUNDO FUNDIDO
    private float contador = 0;
    private float contador2 = 0;
	
	// Update is called once per frame
	void Update ()
    {
        // FUNDIDO DEL PRIMER SPRITE MODIFICANDO SU CANAL ALPHA
        sprite.color += new Color(0, 0, 0, alpha) * Time.deltaTime;
        if(sprite.color.a >= 1)
        {
            contador += Time.deltaTime;
            if(contador >= 5)
            {
                sprite2.color += new Color(0, 0, 0, alpha) * Time.deltaTime;
            }
        }
        // FUNDIDO DEL SEGUNDO SPRITE MODIFICANDO SU CANAL ALPHA
        if (sprite2.color.a >= 1)
        {
            contador2 += Time.deltaTime;
            if (contador2 >= 5)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
