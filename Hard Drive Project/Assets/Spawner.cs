using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform player; 
    public Vector3 Spaw;




    void OnTriggerEnter(Collider col)
    {
       var d = col.gameObject.transform.position;
        
           d = Spaw;
        
    }


}
