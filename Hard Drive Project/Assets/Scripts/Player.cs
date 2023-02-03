using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10.0f, jumpForce = 10.0f;
    public Camera camera;
    private Rigidbody rigidbody;
    private Vector3 direction, nuevaRotacion;
    [SerializeField] private float rotacionZ;
    [SerializeField] private bool seMueve;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        direction=Vector3.zero;
        rotacionZ=0f;
        nuevaRotacion=Vector3.zero;
        seMueve=true;
    }

    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direction = camera.transform.forward * vertical + camera.transform.right * horizontal;
        direction.y = 0;
        direction = direction.normalized;

        Mover(direction * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && Pies.IsGrounded) {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    private void Mover(Vector3 movimiento){
        if(seMueve){
            transform.position += movimiento;

            nuevaRotacion.Set(0, transform.eulerAngles.y, rotacionZ);
            transform.eulerAngles=nuevaRotacion;
            
            if (direction != Vector3.zero) {
                transform.rotation = Quaternion.LookRotation(direction);
            }
        }
    }

}