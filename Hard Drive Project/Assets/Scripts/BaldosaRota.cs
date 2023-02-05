using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaldosaRota : MonoBehaviour {

    Rigidbody baldosaRB;

    void Start(){
        baldosaRB=GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Player") {
            Invoke("ActivarCaida",6f);
            Invoke("DestruirBaldosa",6f);
        }
    }

    void ActivarCaida (){
        baldosaRB.isKinematic=false;
        baldosaRB.useGravity = true;
    }


    void DestruirBaldosa (){
        Destroy(this.gameObject);
    }    

}