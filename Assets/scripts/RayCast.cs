using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public inimigo[] ini= new inimigo[0];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.collider != null)
            {
                if(hit.collider.gameObject.tag =="porta")
                {
                    Destroy(hit.collider.gameObject);
                }
                if(hit.collider.gameObject.tag =="porta2")
                {
                    Destroy(hit.collider.gameObject);
                    ini[0].enabled = true;
                    ini[1].enabled = true;
                    ini[2].enabled = true;
                    ini[3].enabled = true;
                    ini[4].enabled = true;
                    ini[5].enabled = true;
                    ini[6].enabled = true;
                    ini[7].enabled = true;
                }
                if(hit.collider.gameObject.tag =="porta 3")
                {
                    Destroy(hit.collider.gameObject);
                    ini[8].enabled = true;
                    ini[9].enabled = true;
                    ini[10].enabled = true;
                }
                if(hit.collider.gameObject.tag =="porta4")
                {
                    Destroy(hit.collider.gameObject);
                    ini[11].enabled = true;
                    ini[12].enabled = true;
                    ini[13].enabled = true;
                    ini[14].enabled = true;
                    ini[15].enabled = true;
                    ini[16].enabled = true;
                    ini[17].enabled = true;
                }
            }
        }
    }
}

