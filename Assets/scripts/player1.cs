using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public float moveSpeed = 100f;

    private Rigidbody2D rb;

    private Animator ani;   

    private Vector2 moveDirection; 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        
    }
     void Update()
    {
        
        Move();
        
    }

    void Move()
    {
    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");
    moveDirection = new Vector2(moveX, moveY).normalized;
    rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    if(Input.GetAxis("Horizontal") > 0f){ 

    ani.SetBool("andando", true);
    transform.eulerAngles = new Vector3(0f,180f,0f);

    }

    if(Input.GetAxis("Horizontal") < 0f){ 

    ani.SetBool("andando", true);
    transform.eulerAngles = new Vector3(0f,0f,0f);

    }

    if(Input.GetAxis("Horizontal") == 0f){ 

    ani.SetBool("andando", false);

    }
    if(Input.GetAxis("Vertical") > 0f){ 

    ani.SetBool("andando2", true);
    

    }

    if(Input.GetAxis("Vertical") < 0f){ 

    ani.SetBool("andando2", true);
    
    }

    if(Input.GetAxis("Vertical") == 0f){ 

    ani.SetBool("andando2", false);

    }
    
    }
     


   
}