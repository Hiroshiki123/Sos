using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    int vida;
    bool vivo;
    public GameObject jumbas;
    public float Speed;
    private Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        vida = 2;
        vivo = true;
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        destruir();

        Debug.Log(vida);
        Debug.Log(vivo);

        transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "flecha")
        {

            vida = vida - 1;
            Debug.Log("bateu");
        }

        if (vida == 0)
        {
            vivo = false;
        }
    }

        void destruir()
        {
            if (vivo ==false)
            {
                Destroy(jumbas);
            }
        }
        
        void OnCollisionEnter2D(Collision2D collision)
    {
    if(collision.gameObject.tag == "Player")
        {
                        
            GameController.instance.showGameOver();            

        }
    }
    
    
}