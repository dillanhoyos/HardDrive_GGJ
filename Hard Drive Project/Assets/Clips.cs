using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Clips : MonoBehaviour
{
    // Start is called before the first frame update
    [Serializable]
    public class AudioCLap
    {
        public string Name; 
        public AudioClip  clips;

    }

    public AudioSource Source;
    public AudioCLap [] Claps;
    void Start()
    {
        
    }

    public void Play(string AudioClip)
    {
        for(int i = 0; i < Claps.Length; i++)
        {
            if(Claps[i].Name == AudioClip)
            {
                Source.clip = Claps[i].clips;
                
            }
        }
        Source.Play();
    }
}
