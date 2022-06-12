
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Disparar : MonoBehaviour
{
    public GameObject arrow;
    public Transform apuntadorTR;
    Rigidbody rbArrow;
    int tiros = 0;

    public float fuerzaDisparo;

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
        }
        
        
    }

    
}