using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneFinal : MonoBehaviour
{
    public Text winloose;
    public int puntfinal;
    public Image star;
    public int x;

    // Start is called before the first frame update
    void Start()
    {
        x = -100;
        puntfinal = ControlManager.puntaje;
        if (puntfinal >= 200)
        {
            winloose.text = "GANASTE!!";
            for (int i = 0; i <3; i++)
            {
                Instantiate(star, new Vector3(x, -30, 0), Quaternion.identity);
                x = x + 100;
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
