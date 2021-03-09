using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer2 : MonoBehaviour
{
    public Joystick joystick;
    public Transform trans;
    public CharacterController controller;
    public Animator anim;
    public float speed = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        trans.Translate(new Vector3(joystick.Horizontal,joystick.Vertical));
    }
}
