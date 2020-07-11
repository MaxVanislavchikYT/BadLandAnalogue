using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float t = 0;
    [SerializeField] private float currentSpeed = 20f;
    [SerializeField] private float gravity = 20;
    private void Update()
    {


        if (Input.GetMouseButton(0))
        {
            
            transform.position = transform.position + 
                       (new Vector3(0, currentSpeed, 0) * t  - 
                            (new Vector3(0, gravity, 0) * t * t / 2)) * Time.deltaTime;
            
            currentSpeed += Time.deltaTime * 5;
            t += Time.deltaTime;
        }
        else
        {
            
            transform.position = transform.position - 
                                 (new Vector3(0, currentSpeed, 0) * t  - 
                                  (new Vector3(0, gravity, 0) * t * t / 2)) * Time.deltaTime;
            
            t += Time.deltaTime;
            currentSpeed += Time.deltaTime * 5;
            //currentSpeed = Mathf.Max(0, currentSpeed);
            
        }
        

        if (Input.GetMouseButtonDown(0))
        {
            t = 0;
            
            currentSpeed = 0;
        }
        if (Input.GetMouseButtonUp(0))
        {
            t = 0;
            currentSpeed = 0;
        }
        
    }
    
    
    
    
}
