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
           StartCoroutine(Sendbang());
    }
     IEnumerator  Sendbang ()
    {
         

        yield return new  WaitForSeconds(8f);
        drone.SendBang("StartDrone");
        drone.SendBang("MasterSwitch");
        StartCoroutine(Sendbang());
       
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
