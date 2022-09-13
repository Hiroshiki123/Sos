using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portt : MonoBehaviour
{
    public GameObject pott;
    void OnTriggerEnter2D(Collider2D collider)
    {   
    
    if(collider.gameObject.tag == "chave")
        {
           Destroy(pott);       
        }
    }
}
