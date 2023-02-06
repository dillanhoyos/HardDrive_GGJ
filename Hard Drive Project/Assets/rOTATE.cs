using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rOTATE : MonoBehaviour
{
    
    private Puerta rotat;

    void Awake()
    {
        rotat = FindObjectOfType<Puerta>();
    }
    void Start()
    {
        rotat.rotate.AddListener(rotate);
    }
    void rotate()
    {
        this.gameObject.transform.Rotate(180f, 0.0f, 0.0f, Space.Self);
    }




}
