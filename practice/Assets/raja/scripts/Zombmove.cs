using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zombmove : MonoBehaviour
{
    public SpriteRenderer bruh;
    public float count = 0;
    public float zdirx = 1;
    public float speed = 2f;
    public float temp = 0;
    void Awake()
    {
        bruh = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movemf();
    }
    void movemf()
    {
        temp+= speed*Time.deltaTime;
        
        if(temp>=10)
        {
        zdirx = zdirx*-1;
        temp=0;
        }if(zdirx==-1)
        {
            bruh.flipX = true;
        }
        else if(zdirx==1)
        {
            bruh.flipX = false;
        }
        transform.position= transform.position + new Vector3(speed*zdirx,0f,0f)*Time.deltaTime;
    }
}
