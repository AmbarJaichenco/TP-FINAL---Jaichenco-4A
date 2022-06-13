using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    GameObject manager;
    ControlManager controller;
    bool collide;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("[GAMEMANAGER]");
        controller = manager.GetComponent<ControlManager>();
        collide = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (!collide)
        {
            if (col.gameObject.name == "Azul25")
            {
                controller.ActualizarPuntaje(25);
                Debug.Log("Azul");
            }

            if (col.gameObject.name == "Amarillo75")
            {
                controller.ActualizarPuntaje(75);
                Debug.Log("Amarillo");
            }

            if (col.gameObject.name == "Negro10")
            {
                controller.ActualizarPuntaje(10);
                Debug.Log("Negro");
            }

            if (col.gameObject.name == "Rojo50")
            {
                controller.ActualizarPuntaje(50);
                Debug.Log("Rojo");
            }
            collide = true;
        }
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }
}