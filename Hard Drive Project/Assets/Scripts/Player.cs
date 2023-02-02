using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10.0f, jumpForce = 10.0f;
    public Camera camera;
    private Rigidbody rigidbody;
    private Vector3 direction;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        direction=Vector3.zero;
    }

    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direction = camera.transform.forward * vertical + camera.transform.right * horizontal;
        direction.y = 0;
        direction = direction.normalized;

        transform.position += direction * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && Pies.IsGrounded) {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (direction != Vector3.zero) {
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }

}