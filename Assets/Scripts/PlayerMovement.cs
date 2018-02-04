using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    // VELOCIDAD DE MOVIMIENTO DEL JUGADOR
    public float speed;
    // POSICION INICIAL DEL JUGADOR
    private Vector3 iniPos;
    // VECTOR DE MOVIMIENTO DEL JUGADOR
    private Vector2 axis;
    // COMPONENTE PARA ANIMACION JUGADOR
    public Animator anim;
    // ESCALA JUGADOR
    private Vector3 scale;
    // COMPONENTE SPRITERENDER
    public SpriteRenderer sprite;
    // ORDEN DE CAPAS
    private int LayerOrder = 0;
    // BOOLEANO PARA PASAR AL SIGUIENTE NIVEL
    public bool exit;
    // Use this for initialization
    void Start ()
    {
        // INICIALIZAMOS LA POSICION INICIAL DEL JUGADOR
        iniPos = transform.position;
        // INICIALIZAMOS LA ESCALA ACTUAL DEL JUGADOR
        scale = transform.localScale;
    }
	
	// Update is called once per frame
	void Update ()
    {
        // LEER LOS INPUTS DE TECLADO PARA EL MOVIMIENTO
        axis.x = Input.GetAxisRaw("Horizontal");
        axis.y = Input.GetAxisRaw("Vertical");
  
        if(!exit)
        {
            // MOVIMIENTO JUGADOR
            transform.Translate(new Vector3(axis.x, axis.y, 0) * speed * Time.deltaTime);
        }
        if(exit)
        {
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
            anim.SetTrigger("up");
        }
        // CAMBIOS DE ANIMACION
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetTrigger("walk");
            scale.x = -0.27f;
            transform.localScale = scale;
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("walk");
            scale.x = 0.27f;
            transform.localScale = scale;
        }
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger("up");
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetTrigger("down");
        }
    }
    // CAMBIOS DE ORDEN EN LAS CAPAS DE SPRITE
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlataformaSup")
        {
            LayerOrder = 0;
            sprite.sortingOrder = LayerOrder;
        }
        if (collision.tag == "PlataformaMit")
        {
            LayerOrder = 3;
            sprite.sortingOrder = LayerOrder;
        }
        if (collision.tag == "PlataformaInf")
        {
            LayerOrder = 6;
            sprite.sortingOrder = LayerOrder;
        }
        if (collision.tag == "PlataformaExit")
        {
            exit = true;
        }
    }
    public void Reset()
    {
        transform.position = iniPos;
    }
}
