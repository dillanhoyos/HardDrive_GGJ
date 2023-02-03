using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour {
    
    [SerializeField] private Animator playerAnimator, pisoAnimator;
    private bool puerta1, puerta2, puerta3, gravedadVolteada;

    void Start(){
        puerta1=false;
        puerta2=false;
        puerta3=false;
        gravedadVolteada=false;
        Debug.Log(Physics.gravity);
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player" && !puerta1) {
            playerAnimator.SetTrigger("ActivarAnimacion");
            pisoAnimator.SetBool("desactivarCollider", true);
            puerta1=true;
            Invoke("VoltearGravedad", 1.4f);
        } if(other.gameObject.tag=="Player" && !puerta2) {
            playerAnimator.SetTrigger("ActivarAnimacionP2");
            pisoAnimator.SetBool("desactivarCollider", true);
            puerta2=true;
            Invoke("VoltearGravedad", 1.4f);
        } if(other.gameObject.tag=="Player" && !puerta3) {
            playerAnimator.SetTrigger("ActivarAnimacionP3");
            pisoAnimator.SetBool("desactivarCollider", true);
            puerta3=true;
            Invoke("VoltearGravedad", 1.4f);
        }
        Invoke("ResetearPuertas", 4f);
    }

    void ResetearPuertas() {
        puerta1=false;
        puerta2=false;
        puerta3=false;
    }

    void VoltearGravedad() {
        if(!gravedadVolteada) {
            Physics.gravity = -Physics.gravity;
            Debug.Log(Physics.gravity);
            gravedadVolteada=true;
        }
    }

}