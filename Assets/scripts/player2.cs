using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player2 : MonoBehaviour
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
    float moveX = Input.GetAxisRaw("Horizontal2");
    float moveY = Input.GetAxisRaw("Vertical2");
    moveDirection = new Vector2(moveX, moveY).normalized;
    rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
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
    void OnCollisionEnter2D(Collision2D collision)
    {   
    
    if(collision.gameObject.tag == "portal")
        {
                        
             SceneManager.LoadScene("fase2");          

        }
        if(collision.gameObject.tag == "cristal")
        {
                        
             SceneManager.LoadScene("menu");          

        }
    
    }
    
}
     


   
