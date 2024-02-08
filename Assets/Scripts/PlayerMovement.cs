using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float forwardForce = 2000f;
    [SerializeField] private float sidewaysForce = 500f;
    public bool movement = false;
    [SerializeField] private bool isMovingLeft = false;
    [SerializeField] private bool isMovingRight = false;

    void FixedUpdate()
    {
        if(movement)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        ButtonMovement();

        KeyBoardMovement();

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void ButtonMovement()
    {
        if(isMovingRight)
        {
            MoveRight();
        }

        if(isMovingLeft)
        {
            MoveLeft();
        }
    }

    void KeyBoardMovement()
    {
        if(Input.GetKey("right"))
        {
            MoveRight();
        }

        if(Input.GetKey("left"))
        {
            MoveLeft();
        }
    }

    public void TriggerLeft(bool canMove)
    {
        isMovingLeft = canMove;
    }

    public void TriggerRight(bool canMove)
    {
        isMovingRight = canMove;
    }

    void MoveRight()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    void MoveLeft()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    
}
