using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zombmove : MonoBehaviour
{
    bool b = true;
    public float zdirx = 1;
    public float speed = 2f;
    private Transform temp;
    private void Awake()
    {
     do{
    temp = GetComponent<Transform>();
     }while(b);
    }

    // Start is called before the first frame update
    void Start()
    {
        Awake();
    }

    // Update is called once per frame
    void Update()
    {
        movemf();
    }
    void movemf()
    {
        
        if((temp.position.x-transform.position.x)>=10||(transform.position.x-temp.position.x)>=10)
        {
        zdirx = zdirx*-1;
        temp.position = transform.position;
        }
        print(temp.position+" "+transform.position);
        transform.position= transform.position + new Vector3(speed*zdirx,0f,0f)*Time.deltaTime;
    }
}
