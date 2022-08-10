using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float moveSpeed = 100f;

    public Rigidbody2D rb;

    Vector2 movement;

    

    private int vel;
     void Update()
    {
        vel = 2;
        movement.x = Input.GetAxisRaw("Horizontal2");
        movement.y = Input.GetAxisRaw("Vertical2");

    
    }


    private void FixedUpdate()
    {
        vel = 2;

        if (Input.GetKey(KeyCode.LeftShift)) {
            vel = 5;
        }

        rb.MovePosition(rb.position + movement * vel * Time.fixedDeltaTime);    }
}
