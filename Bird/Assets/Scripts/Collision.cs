using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // AudioSource fuenteDeAudio;
    //  public AudioClip puntos;
    
     void Start()
    {
        
        //Recupero el componente audio source;
       // fuenteDeAudio = GetComponent<AudioSource>();
    }
   private void OnTriggerEnter2D(Collider2D Collision)
   {
       Puntaje.puntaje++;
       // fuenteDeAudio.clip = puntos;
       // fuenteDeAudio.Play();
   }
}
