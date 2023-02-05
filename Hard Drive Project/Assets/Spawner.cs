using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    public Vector3 Spaw;




    void OnTriggerEnter(Collider col)
    {
        var c = col.gameObject.name;
       var d = col.gameObject.transform.position;
       d = Spaw;
       
    }


}
