using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public Transform player;
    public Vector3 tempos;
    private float minx = -60;
    private float maxx = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cameramove();
    }
    void cameramove(){
        player = GameObject.FindWithTag("Player").transform;
        tempos = transform.position;
        tempos.x=player.position.x;
        if(tempos.x>maxx)
        tempos.x=maxx;
        if(tempos.x<minx)
        tempos.x=minx;
        transform.position = tempos;
        
        
    }
}
