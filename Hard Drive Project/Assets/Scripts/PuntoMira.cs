using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoMira : MonoBehaviour {

    [SerializeField] GameObject player;
    
    void LateUpdate() {
        transform.position=player.transform.position;
    }
    
}