using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour
{

    public GameObject mao;
    public SpriteRenderer spr;


    private void FixedUpdate()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        diff.Normalize();

        float rotationZ = Mathf.Atan2(diff.y,diff.x)* Mathf.Rad2Deg;

        
        if(rotationZ < 90 & rotationZ > -90)
        {
            spr.flipX = true;
        }
        else
        {
         spr.flipX = false;
        }
        
         
    }

 
}

