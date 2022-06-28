using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlManager : MonoBehaviour
{
    public Text cartel;
    public static int puntaje;

    public GameObject arrowfija;
    public GameObject arrowprefab;
    

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;

    }

    void Update()
    {
        if(Time.time > 180)
        {
            SceneFinal();
        }
    }

    public void ActualizarPuntaje(int puntos)
    {
        puntaje = puntaje + puntos;
        cartel.text = puntaje.ToString();
    }

    public void SceneFinal()
    {
        SceneManager.LoadScene("SceneFinal");
    }
}
