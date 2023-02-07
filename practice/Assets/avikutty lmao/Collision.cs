using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

   void OnCollisionEnter2D(Collision2D other) {

        Debug.Log("boi you dented the car!");
   }

   void OnTriggerExit2D(Collider2D other) {
      
      if (other.tag == "Package") {
         Debug.Log("You picked up the SAUCE!!!");
      }
   }
}
