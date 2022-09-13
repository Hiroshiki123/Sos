using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{
    public GameObject faca;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ata();
    }
    void ata()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            faca.SetActive(true);
        }
        else
        {
            faca.SetActive(false);
        }
    }
}
