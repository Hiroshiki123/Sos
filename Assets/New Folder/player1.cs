using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public float moveSpeed = 100f;

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
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
    transform.position += movement*Time.deltaTime * moveSpeed;
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