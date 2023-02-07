using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject characterVehicle;
    
    void LateUpdate()
    {
        transform.position = characterVehicle.transform.position + new Vector3 (0,0,-1);
    }
}
