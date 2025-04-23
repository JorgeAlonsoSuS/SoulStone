using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    [SerializeField]
    private float speed = 5f;
    private bool isGrounded;
    public float gravity = -9.8f;

    private Vector3 movemeDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void ProcessMove(Vector2 input)
    {   
        movemeDirection = Vector3.zero;
        movemeDirection.x = input.x;
        movemeDirection.z = input.y;
        controller.Move(transform.TransformDirection(movemeDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }
        controller.Move(playerVelocity * Time.deltaTime);
    
    }
}
