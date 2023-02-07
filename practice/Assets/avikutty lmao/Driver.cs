using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float movementVelocity = 14f;
    float steerSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm the taxi driver!"); 
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = -1f * Input.GetAxis("Horizontal") * Time.deltaTime * steerSpeed;

        float increaseSpeed = Input.GetAxis("Vertical") * Time.deltaTime * movementVelocity;  

        transform.Rotate (0 , 0 , steerAmount);
        transform.Translate (0 , increaseSpeed , 0);
    }
}