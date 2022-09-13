using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chave2 : MonoBehaviour
{
    
    public chave cha;
    void start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {   
    
    if(collider.gameObject.tag == "Player")
        {
           cha.enabled = true;       
        }
    }
    
}
