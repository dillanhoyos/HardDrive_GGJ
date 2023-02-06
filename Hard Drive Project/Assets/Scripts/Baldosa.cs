using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baldosa : MonoBehaviour {

    private Animator baldosaAnimator;

    void Start () {
        baldosaAnimator = this.GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Player") {

            baldosaAnimator.SetTrigger("ActivarBaldosa");
        }
    }

}