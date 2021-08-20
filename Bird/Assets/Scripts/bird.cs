using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    public Director directorJuego;
    public float velocity = 1;
    private Rigidbody2D rb;
    AudioSource fuenteDeAudio;
    public AudioClip wing_bird,fin_juego;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Recupero el componente audio source;
        
        fuenteDeAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            fuenteDeAudio.clip = wing_bird;
            fuenteDeAudio.Play();
            rb.velocity = Vector2.up * velocity;
        
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fuenteDeAudio.clip = fin_juego;
            fuenteDeAudio.Play();
        directorJuego.Gameover();
    }
}
