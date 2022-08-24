using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public float moveSpeed = 100f;

    public Rigidbody2D rb;

    Vector2 movement;

    private Animator ani;    

    private int vel;

    void Start()
    {
        ani = GetComponent<Animator>();
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
     void Update()
    {
        vel = 2;
        Move();
        
    }

    void Move()
    {
        
        if (Input.GetAxis("Horizontal") > 0f)
        {
            ani.SetBool("andando", true);

        }
        if (Input.GetAxis("Horizontal") < 0f)
        {
            ani.SetBool("andando", true);

        }
        if (Input.GetAxis("Horizontal") == 0f)
        {
            ani.SetBool("andando", false);

        }
        if (Input.GetAxis("Vertical") > 0f)
        {
            ani.SetBool("andando", true);


        }
        if (Input.GetAxis("Vertical") < 0f)
        {
            ani.SetBool("andando", true);


        }
        if (Input.GetAxis("Vertical") == 0f)
        {
            ani.SetBool("andando", false);


        }
        // transform.position += movement * Time.deltaTime * vel; 
        rb.MovePosition(rb.position + movement * vel * Time.fixedDeltaTime);
    }
    
    
     


    private void FixedUpdate()
    {
        vel = 2;

        if (Input.GetKey(KeyCode.LeftShift)) {
            vel = 5;
        }

       }
}