using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

   [SerializeField] Color32 hasSAUCE = new Color32 (1 , 1 , 1 , 1);
   [SerializeField] Color32 noSAUCE = new Color32 (0 , 0 , 1 , 1);

   Vector3 newTeleportPosition = new Vector3 (-45 , -10, 0);

   SpriteRenderer colour;

   Transform teleport;

   void Start()
   {
      colour = GetComponent<SpriteRenderer>();

      teleport = GetComponent<Transform>();
   }
   bool isPizzaPicked = false;
   [SerializeField] float timeDestroyed = 1f;

   void OnCollisionEnter2D(Collision2D other) 
   {
        Debug.Log("boi you dented the car!");
   }

   void OnTriggerEnter2D(Collider2D other)
   {
      if (other.tag == "Package" && !isPizzaPicked) 
      {
         Debug.Log("You picked up the SAUCE!!!");
         isPizzaPicked = true;
         colour.color = hasSAUCE;
         Destroy(other.gameObject, timeDestroyed);
      } 

      if (other.tag == "Delivery" && isPizzaPicked)
      {
         Debug.Log("All you had to do was delivery the damn pizza... driver");
         isPizzaPicked = false;
         colour.color = noSAUCE;
         teleport.position = newTeleportPosition; 
      }

   }
}
