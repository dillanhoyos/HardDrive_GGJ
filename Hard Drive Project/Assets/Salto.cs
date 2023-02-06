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
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Pies.IsGrounded) {
            PlayEvent();
                }
    }
   public void PlayEvent()
   {
     Audio.pitch = Random.RandomRange(0.8f, 1f);
     Audio.clip = Saltos[Random.RandomRange(0, Saltos.Length)];
     Audio.Play();
   }
}
