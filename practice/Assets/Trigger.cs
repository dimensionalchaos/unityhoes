using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        
        Debug.Log("You ENTERED the white ass box brah");
    }
 
    void OnTriggerExit2D(Collider2D other) {
        
        Debug.Log("You EXITED the white ass box brah");
    }
}
