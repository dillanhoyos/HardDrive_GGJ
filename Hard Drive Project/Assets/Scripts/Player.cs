using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10.0f, jumpForce = 15.0f;
    private float horizontal, vertical;
    public Camera camera;
    private Rigidbody rigidbody;
    private Vector3 direction, nuevaRotacion, vectorSalto;
    [SerializeField] private float rotacionZ;
    [SerializeField] private bool seMueve;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        direction=Vector3.zero;
        rotacionZ=0f;
        nuevaRotacion=Vector3.zero;
        seMueve=true;
        vectorSalto=Vector3.up;
    }

    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        direction = camera.transform.forward * vertical + camera.transform.right * horizontal;
        direction.y = 0;
        direction = direction.normalized;

        Mover(direction * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && Pies.IsGrounded) {
            if(!Puerta.gravedadVolteada){
                rigidbody.AddForce(vectorSalto * jumpForce, ForceMode.Impulse);
            } else {
                rigidbody.AddForce(-vectorSalto * jumpForce, ForceMode.Impulse);
            }
                
        }

    }

    private void Mover(Vector3 movimiento){
        if(seMueve){
            transform.position += movimiento;
            
            if (direction != Vector3.zero) {
                transform.rotation = Quaternion.LookRotation(direction);
            }

            nuevaRotacion.Set(0, transform.eulerAngles.y, rotacionZ);
            transform.eulerAngles=nuevaRotacion;
        }
    }

}