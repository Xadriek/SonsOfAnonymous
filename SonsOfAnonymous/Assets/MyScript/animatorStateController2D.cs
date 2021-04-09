using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorStateController2D : MonoBehaviour
{
    Animator animator;

    float velocityZ = 0.0f;
    float velocityX = 0.0f;
    
    public float acceleration = 2.0f;
    public float deceleration = 2.0f;


 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
   
    }

    // Update is called once per frame
    void Update()
    {

        bool forwardPressed = true;
        bool leftPressed = false;
        bool rightPressed = false;
        bool backwardPressed = false;
       

        if (forwardPressed)
        {
            velocityZ += Time.deltaTime * acceleration;
            
        }
        if (leftPressed)
        {
            velocityX -= Time.deltaTime * acceleration;
            
        }
        if (rightPressed)
        {
            velocityX += Time.deltaTime * acceleration;
            
        }
        if (backwardPressed)
        {
            velocityZ -= Time.deltaTime * acceleration;
            
        }
        animator.SetFloat("VelocityZ", velocityZ);
        animator.SetFloat("VelocityX", velocityX);
    
    }


}
