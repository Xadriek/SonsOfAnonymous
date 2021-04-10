using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorStateController2D : MonoBehaviour
{
    Animator animator;
    PlayerController playerController;
    private Player playerInput;
    float velocityZ = 0.0f;
    float velocityX = 0.0f;

    public float acceleration = 2.0f;
    public float deceleration = 2.0f;
    public float maximunWalkVelocity = 0.5f;
    public float maximunRunVelocity = 2.0f;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerController = GetComponentInParent<PlayerController>();
        playerInput = playerController.getPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementInput = playerInput.PlayerMain.move.ReadValue<Vector2>();
        //float currentMaxVelocity = movementInput.x > 0 ? maximunRunVelocity : maximunWalkVelocity;


        if (movementInput.y > 0 && velocityZ<2.0f)
        {
            velocityZ += Time.deltaTime * acceleration;

        }
        if (movementInput.x < 0 && velocityX > -0.5f)
        {
            velocityX -= Time.deltaTime * acceleration;

        }
        if (movementInput.x > 0 && velocityX < 0.5f)
        {
            velocityX += Time.deltaTime * acceleration;

        }
        if (movementInput.y < 0 && velocityZ > -0.5f)
        {
            velocityZ -= Time.deltaTime * acceleration;

        }
        if(!(movementInput.y>0) && velocityZ > 0.0f)
        {
            velocityZ -= Time.deltaTime * deceleration;
        }
        if (!(movementInput.y > 0) && velocityZ < 0.0f)
        {
            velocityZ = 0.0f;
        }
        if (!(movementInput.x < 0) && velocityX < 0.0f)
        {
            velocityX += Time.deltaTime * deceleration;
        }
        if (!(movementInput.x > 0) && velocityX < 0.0f)
        {
            velocityX += Time.deltaTime * deceleration;
        }
        if(!(movementInput.x<0 && movementInput.x>0 && velocityX!=0.0f && (velocityX>-0.05f && velocityX < 0.05f)))
        {
            velocityX = 0.0f;
        }

        animator.SetFloat("VelocityZ", velocityZ);
        animator.SetFloat("VelocityX", velocityX);

    }


}
