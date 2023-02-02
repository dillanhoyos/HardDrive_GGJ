using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour {

    public static bool IsGrounded;
    private Vector3 rotacion;
    [SerializeField] GameObject player;

    void Start() {
        rotacion=Vector3.zero;
    }

    void LateUpdate() {
        transform.position=player.transform.position;
        transform.rotation=Quaternion.LookRotation(rotacion);
    }

    void OnTriggerStay(Collider other) {
        IsGrounded=true;
    }

    void OnTriggerExit(Collider other){
        IsGrounded=false;
    }
}