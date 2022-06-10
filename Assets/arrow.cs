using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    int puntos = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject); 
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Amarillo75")
        {
            Debug.Log("Amarillo75");
            puntos = puntos + 75;
            Destroy(gameObject);
        }

    }

    




}