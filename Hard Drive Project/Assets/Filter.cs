using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filter : MonoBehaviour
{
    public AudioLowPassFilter ilter;
    // Start is called before the first frame update
   private Puerta rotat;

    void Awake()
    {
        rotat = FindObjectOfType<Puerta>();
    }
    void Start()
    {
        rotat.rotate.AddListener(Fi);

    }

    void Fi()
    {
        ilter.cutoffFrequency = 10000;
    }
}
