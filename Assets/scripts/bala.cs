using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bala : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] ParticleSystem effect;
    Rigidbody2D rg;
    int dano = 2;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    } 
    
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(effect, transform.position, transform.rotation);
        rg.isKinematic = false;
        Destroy(gameObject);
       
    }




}
