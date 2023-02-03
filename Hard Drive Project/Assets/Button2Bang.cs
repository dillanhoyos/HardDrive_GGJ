using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2Bang : MonoBehaviour
{
    public LibPdInstance pdPatch;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        pdPatch.SendBang("TriggerOn");

    }
    void OnTriggerExit(Collider other)
    {
        pdPatch.SendBang("triggerOff");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
