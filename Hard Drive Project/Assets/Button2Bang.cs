using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2Bang : MonoBehaviour
{
    private LibPdInstance pdPatch;
   
    private GameObject[] SoundScape;
    public string message;
    public bool isSoundBoop = true;
    

    // Start is called before the first frame update

    void Start()
    {
       SoundScape = GameObject.FindGameObjectsWithTag("SoundScape");
        if(isSoundBoop)
        {
          pdPatch =  transform.root.gameObject.GetComponent<LibPdInstance>();
        }
        else 
        {
         
          pdPatch = SoundScape[0].GetComponent<LibPdInstance>();
        }
         
    }
    void OnTriggerEnter(Collider other)
    {
        pdPatch.SendBang(message);
        

    }
    // void OnTriggerExit(Collider other)
    // {
    //     pdPatch.SendBang("triggerOff");

    // }

    // Update is called once per frame
    void Update()
    {

    }
}
