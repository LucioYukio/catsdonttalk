using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima : MonoBehaviour
{
    public Animator playeranimator;
    float input_x = 0f;
    float input_y = 0f;
    public float speed = 1.5f;
    bool IsWalking = false;
    public float Speed;
    public Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        IsWalking = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        input_x = Input.GetAxis("Horizontal");
        input_y = Input.GetAxis("Vertical");
        IsWalking = (input_x != 0 || input_y != 0);
        Vector2 movement = new Vector2(input_x, input_y);
        if (IsWalking)
        {   
            playeranimator.SetFloat("Input_X", input_x);
            playeranimator.SetFloat("Input_Y", input_y);

        }
        if (movement.magnitude >= 1)
        {
            movement = movement.normalized;
        }
        body.velocity = movement * Speed;
        playeranimator.SetBool("IsWalking",IsWalking);
    }
}
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playeranimator;
    float input_x = 0f;
    float input_y = 0f;
    bool IsWalking;
    public float Speed;
    public Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        IsWalking = true;
    }

    // Update is called once per frame
    void Update()
    {
        input_x = Input.GetAxis("Horizontal");
        input_y = Input.GetAxis("Vertical");
        //IsWalking = (input_x != 0 || input_y != 0);
        if (IsWalking)
        {
            Vector2 movement = new Vector2(input_x, input_y);
            if (movement.magnitude >= 1)
            {
                movement = movement.normalized;
            }
            body.velocity = movement * Speed;
        }

    }
}*/
//viado, torcam de