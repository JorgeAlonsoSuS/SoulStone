using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    private float xRotation = 0f;

    [SerializeField]
    private float xSensitivity = 30f;
    [SerializeField]
    private float ySensitivity = 30f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
    public void ProcessLook(Vector2 input)
    {
        float mousex = input.x;
        float mousey = input.y;

        xRotation -= (mousey * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        transform.Rotate(Vector3.up * (mousex * Time.deltaTime) * xSensitivity);
    }
}
