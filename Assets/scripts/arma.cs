using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{
    SpriteRenderer sprite;
    // Start is called before the first frame update

    public GameObject bala;
    public Transform SpawnTiro;
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public void Update()
    {
        Aim();
        Tiro();
    }

    public void Tiro()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bala, SpawnTiro.position, transform.rotation);
            
        }
    }


    void Aim()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 offset = new Vector2(mousePos.x - screenPoint.x, mousePos.y - screenPoint.y);

        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);
        
        sprite.flipY = (mousePos.x < screenPoint.x);
    }
}
