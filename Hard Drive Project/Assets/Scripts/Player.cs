using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    private Rigidbody rigidbody;
    private Vector3 direction;
    private float distanceToGround;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        direction=Vector3.zero;
    }

    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direction.Set(horizontal, 0, vertical);
        transform.position += direction * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    bool IsGrounded() {
        distanceToGround = GetComponent<Collider>().bounds.extents.y;
        return Physics.Raycast(transform.position, -Vector3.up, distanceToGround + 0.1f);
    }

}