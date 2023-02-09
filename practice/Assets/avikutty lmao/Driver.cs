using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float movementVelocity = 14f;
    float steerSpeed = 180f;

    float SPEED = 20f;

    float SLOW = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm the taxi driver!"); 
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.tag == "SPEED")
        {
            movementVelocity = SPEED;
        }    
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        movementVelocity = SLOW;   
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