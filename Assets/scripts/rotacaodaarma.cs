using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacaodaarma : MonoBehaviour
{

    public GameObject mao;

    private void FixedUpdate()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        diff.Normalize();

        float rotationZ = Mathf.Atan2(diff.y,diff.x)* Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f,0f,rotationZ);
        if(rotationZ < -90 || rotationZ >90)
        {
            if(mao.transform.eulerAngles.y == 0)
            {
              transform.localRotation = Quaternion.Euler(180,0, -rotationZ);
            }else if(mao.transform.eulerAngles.y == 180)
            {

                transform.localRotation = Quaternion.Euler(180, 180, -rotationZ);
            }
        }
    }

 
}
