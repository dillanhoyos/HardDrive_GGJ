using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour {
    
    [SerializeField] private Animator playerAnimator, pisoAnimator, cameraAnimator, mainCameraAnimator;
    private bool puerta1, puerta2, puerta3;
    public static bool gravedadVolteada;

    void Start(){
        puerta1=false;
        puerta2=false;
        puerta3=false;
        gravedadVolteada=false;
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player" && !puerta1) {
            playerAnimator.SetTrigger("ActivarAnimacion");
            pisoAnimator.SetBool("desactivarCollider", true);
            cameraAnimator.SetTrigger("RotarCamara");
            puerta1=true;
            Invoke("VoltearGravedad", 1f);
        } if(other.gameObject.tag=="Player" && !puerta2) {
            playerAnimator.SetTrigger("ActivarAnimacionP2");
            pisoAnimator.SetBool("desactivarCollider", true);
            cameraAnimator.SetTrigger("RotarCamara");
            puerta2=true;
            Invoke("VoltearGravedad", 1f);
        } if(other.gameObject.tag=="Player" && !puerta3) {
            playerAnimator.SetTrigger("ActivarAnimacionP3");
            pisoAnimator.SetBool("desactivarCollider", true);
            cameraAnimator.SetTrigger("RotarCamara");
            puerta3=true;
            Invoke("VoltearGravedad", 1f);
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
            gravedadVolteada=true;
        }
    }

}