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
    }
     

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
