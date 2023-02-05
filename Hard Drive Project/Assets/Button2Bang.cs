using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2Bang : MonoBehaviour
{
   private LibPdInstance pdPatch;
    public string message;

    // Start is called before the first frame update

    void Start()
    {
      pdPatch =  transform.root.gameObject.GetComponent<LibPdInstance>();
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
