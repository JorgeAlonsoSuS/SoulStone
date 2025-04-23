using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManger : MonoBehaviour
{
    private Conroles playerInput;
    private Conroles.PlayerNeutralActions neutralActions;

    private PlyerMotor motor;
    private PlayerLook look;

    void Awake()
    {
        playerInput = new Conroles();
        neutralActions = playerInput.PlayerNeutral;
        motor = GetComponent<PlyerMotor>();
        look = GetComponent<PlayerLook>();

    }

    void FixedUpdate()
    {
        motor.ProcessMove(neutralActions.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        look.ProcessLook(neutralActions.Look.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        neutralActions.Enable();   
    }

    private void OnDisable()
    {
        neutralActions.Disable();
    }
}
