using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    public Vector3 Spaw;
    public Transform Player;




    void OnTriggerEnter(Collider col)
    {
     
       Player.position = Spaw;
       
    }


}
