
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Disparar : MonoBehaviour
{
    public GameObject arrow;
    public GameObject manager;
    public Transform apuntadorTR;
    Rigidbody rbArrow;
    public int tiros = 0;
    public float fuerzaDisparo;
    public Text tirostxt;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject clon;
            clon = Instantiate(arrow, apuntadorTR.position, apuntadorTR.rotation);
            rbArrow = clon.GetComponent<Rigidbody>();
            rbArrow.AddForce(clon.transform.up * fuerzaDisparo, ForceMode.Impulse);
            Destroy(clon, 1);
            tiros++;
            tirostxt.text = tiros.ToString();
        }

        if (tiros >= 10)
        {
            SceneFinal();
        }
    }

    public void SceneFinal()
    {
        SceneManager.LoadScene("SceneFinal");
    }
}