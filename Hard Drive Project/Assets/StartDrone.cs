using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDrone : MonoBehaviour
{
    public LibPdInstance drone; 

    // Start is called before the first frame update
    void Awake()
    {   
        drone = drone.GetComponent<LibPdInstance>();
     
        
    }
    void Start()
    {
        drone.SendBang("Reverse");
    }
     
     void OnDisable()
     {
         drone.SendBang("Reverse");
     }

}
