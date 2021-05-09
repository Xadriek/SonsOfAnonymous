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

    int VelocityZHash;
    int VelocityXHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerController = GetComponentInParent<PlayerController>();
        playerInput = playerController.getPlayer();
        VelocityZHash = Animator.StringToHash("VelocityZ");
        VelocityXHash = Animator.StringToHash("VelocityX");
    }
    void lockOrResetVelocity(bool forwardPressed, bool leftPressed, bool rightPressed, bool runPressed, bool backwardPressed, float currentMaxVelocity)
    {
        if (!forwardPressed && velocityZ < 0.0f)
        {
            velocityZ = 0.0f;
        }
        if (!leftPressed && !rightPressed && velocityX != 0.0f && (velocityX > -0.05f && velocityX < 0.05f))
        {
            velocityX = 0.0f;
        }
        if (forwardPressed && runPressed && velocityZ > currentMaxVelocity)
        {
            velocityZ = currentMaxVelocity;
        }
        else if (forwardPressed && velocityZ > currentMaxVelocity)
        {

            velocityZ -= Time.deltaTime * deceleration;
            if (velocityZ > currentMaxVelocity && velocityZ < (currentMaxVelocity + 0.05f))
            {
                velocityZ = currentMaxVelocity;
            }
        }
        else if (forwardPressed && velocityZ < currentMaxVelocity && velocityZ > (currentMaxVelocity - 0.05f))
        {
            velocityZ = currentMaxVelocity;
        }
        if (leftPressed && runPressed && velocityX < -currentMaxVelocity)
        {
            velocityX = -currentMaxVelocity;
        }
        else if (leftPressed && velocityX < -currentMaxVelocity)
        {
            velocityX += Time.deltaTime * deceleration;
            if (velocityX < -currentMaxVelocity && velocityX > (-currentMaxVelocity + 0.05f))
            {
                velocityX = currentMaxVelocity;
            }
        }
        if (rightPressed && runPressed && velocityX > currentMaxVelocity)
        {
            velocityX = -currentMaxVelocity;
        }
        else if (rightPressed && velocityX > currentMaxVelocity)
        {
            velocityX -= Time.deltaTime * deceleration;
            if (velocityX > currentMaxVelocity && velocityX < (currentMaxVelocity + 0.05f))
            {
                velocityX = currentMaxVelocity;
            }
        }
    }
    void changeVelocity(bool forwardPressed, bool leftPressed, bool rightPressed, bool runPressed, bool backwardPressed, float currentMaxVelocity)
    {
        if (forwardPressed && velocityZ < currentMaxVelocity)
        {
            velocityZ += Time.deltaTime * acceleration;

        }
        if (leftPressed && velocityX > -currentMaxVelocity)
        {
            velocityX -= Time.deltaTime * acceleration;

        }
        if (rightPressed && velocityX < currentMaxVelocity)
        {
            velocityX += Time.deltaTime * acceleration;

        }
        if (backwardPressed && velocityZ > -currentMaxVelocity)
        {
            velocityZ -= Time.deltaTime * acceleration;

        }
        if (!forwardPressed && velocityZ > 0.0f)
        {
            velocityZ -= Time.deltaTime * deceleration;
        }
        if (backwardPressed && velocityZ < 0.0f)
        {
            velocityZ += Time.deltaTime * deceleration;

        }
        if (!leftPressed && velocityX < 0.0f)
        {
            velocityX += Time.deltaTime * deceleration;
        }
        if (!rightPressed && velocityX > 0.0f)
        {
            velocityX -= Time.deltaTime * deceleration;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementInput = playerInput.PlayerMain.move.ReadValue<Vector2>();


        bool forwardPressed = movementInput.y > 0;
        bool leftPressed = movementInput.x < 0;
        bool rightPressed = movementInput.x > 0;
        bool backwardPressed = movementInput.y < 0;
        bool runPressed = false;

        float currentMaxVelocity = runPressed ? maximunRunVelocity : maximunWalkVelocity;

        changeVelocity(forwardPressed, leftPressed, rightPressed, runPressed, backwardPressed, currentMaxVelocity);
        lockOrResetVelocity(forwardPressed, leftPressed, rightPressed, runPressed, backwardPressed, currentMaxVelocity);
        

        animator.SetFloat(VelocityZHash, velocityZ);
        animator.SetFloat(VelocityXHash, velocityX);

    }


}
