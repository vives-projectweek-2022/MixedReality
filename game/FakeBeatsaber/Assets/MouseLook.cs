using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{

    public InputActionReference horizontalLook;
    public InputActionReference verticalLook;
    public float HorizontallookSpeed = 1f;
    public float VerticalLookSpeed = 0.001f;
    public Transform cameraTransform;
    private float pitch;
    private float yaw;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        horizontalLook.action.performed += HandleHorizontalLookChange;
        verticalLook.action.performed += HandleVerticalLookChange;
    }

    void HandleHorizontalLookChange(InputAction.CallbackContext obj)
    {
        yaw += obj.ReadValue<float>();
        transform.localRotation = Quaternion.AngleAxis(yaw * HorizontallookSpeed, Vector3.up);

    }

    void HandleVerticalLookChange(InputAction.CallbackContext obj)
    {
        pitch -= obj.ReadValue<float>();
        transform.localRotation = Quaternion.AngleAxis(pitch * VerticalLookSpeed, Vector3.right);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
