using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 40f;

    public float turnspeed = 180f;

    float horizontalInput;
    float verticalInput; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *Time.deltaTime * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnspeed);
    }
}
