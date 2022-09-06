using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bala : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] ParticleSystem effect;
    public GameObject collected;
    Rigidbody2D rg;
    

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    } 
    
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        morte();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
       if(collider.gameObject.tag =="inimigo")
       {
           Destroy(gameObject);
       } 
       
    }
    void morte()
    {
        Destroy(gameObject, 1.5f);
    }




}
