using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlManager : MonoBehaviour
{
    public Text cartel;
    public int puntaje;
    public GameObject panel;
    public GameObject arrowfija;
    public GameObject arrowprefab;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActualizarPuntaje(int puntos)
    {
        puntaje = puntaje + puntos;
        cartel.text = puntaje.ToString();
    }

    public void AbrirMenu()
    {
        panel.SetActive(true);
    }

    public void CerrarMenu()
    {
        panel.SetActive(false);
    }
}
