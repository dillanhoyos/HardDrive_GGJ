using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayS : MonoBehaviour
{
     private Puerta rotat;

     AudioSource Audio;

    void Awake()
    {
        Audio = this.gameObject.GetComponent<AudioSource>();
        rotat = FindObjectOfType<Puerta>();
    }
    void Start()
    {
        rotat.rotate.AddListener(Ti);

    }
    void Ti()
    {
        Audio.Play();
    }
}
