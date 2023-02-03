using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour {

    public static bool IsGrounded;
    [SerializeField] GameObject player;
    private Vector3 rotacion;

    void LateUpdate() {
        transform.position=player.transform.position;
        rotacion.Set(0f,0f,-player.transform.eulerAngles.z);
        transform.eulerAngles = rotacion;
    }

    void OnTriggerStay(Collider other) {
        IsGrounded=true;
    }

    void OnTriggerExit(Collider other){
        IsGrounded=false;
    }
}