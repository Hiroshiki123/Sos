using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chave : MonoBehaviour
{
    public GameObject chavee;
    // Start is called before the first frame update
    public float Speed;
    private Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {   
    
    if(collider.gameObject.tag == "pot")
        {
           Destroy(chavee);       
        }
    }
}
