
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1move : MonoBehaviour
{
[SerializeField]
private float dirx;
private float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        transform.position+= new Vector3(dirx,0,0)*speed* Time.deltaTime;


        
    }
}
