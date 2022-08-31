using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float moveSpeed = 10f;

    private Rigidbody2D rb;

    private Animator ani;    

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
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0f);
    transform.position += movement*Time.deltaTime * moveSpeed;
    if(Input.GetAxis("Horizontal2") > 0f){ 

    ani.SetBool("andando", true);
    

    }

    if(Input.GetAxis("Horizontal2") < 0f){ 

    ani.SetBool("andando", true);
    

    }

    if(Input.GetAxis("Horizontal2") == 0f){ 

    ani.SetBool("andando", false);

    }
    if(Input.GetAxis("Vertical2") > 0f){ 

    ani.SetBool("andando2", true);
    

    }

    if(Input.GetAxis("Vertical2") < 0f){ 

    ani.SetBool("andando2", true);
    
    }

    if(Input.GetAxis("Vertical2") == 0f){ 

    ani.SetBool("andando2", false);

    }
    
    }
     


   
}