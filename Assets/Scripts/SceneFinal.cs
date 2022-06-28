using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneFinal : MonoBehaviour
{
    public Text winloose;
    public int puntfinal;
    public GameObject yey;
    

    // Start is called before the first frame update
    void Start()
    {
        puntfinal = ControlManager.puntaje;
        if (puntfinal >= 200)
        {
            winloose.text = "GANASTE!!";
            for (int i = 0; i <50; i++)
            {
                Debug.Log("funca");

                Instantiate(yey, new Vector3(-3, 5.5f, 61.9f), Quaternion.identity);

            }
        }
        else
        {
            winloose.text = "PERDISTE :(";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
