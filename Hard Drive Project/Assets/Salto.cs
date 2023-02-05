using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class Salto : MonoBehaviour
{
   public AudioClip [] Saltos; 
   public AudioSource Audio;




    void Start()
    {
        Audio = this.GetComponent<AudioSource>();
    }

   public void PlayEvent()
   {
     Audio.clip = Saltos[Random.RandomRange(0, Saltos.Length)];
     Audio.Play();
   }
}
