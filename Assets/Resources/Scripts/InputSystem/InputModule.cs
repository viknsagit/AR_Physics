using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputModule : MonoBehaviour
{
    private Controls inputActions;
    private Camera camera;
    private void Start()
    {
        inputActions.Mobile.Move.performed += Move_performed;
        camera = Camera.main;
    }

    private void Move_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Vector3 moveVector = new Vector3(obj.ReadValue<Vector3>().x, obj.ReadValue<Vector3>().y, obj.ReadValue<Vector3>().z);
        camera.transform.TransformDirection(moveVector);
    }

    private void Awake()
    {
        inputActions = new Controls();
    }

    private void OnEnable()
    {
        inputActions.Enable();
        InputSystem.EnableDevice(UnityEngine.InputSystem.Gyroscope.current);
        inputActions.Mobile.Move.performed += Move_performed;
    }
    private void OnDisable()
    {
        inputActions.Disable();
        inputActions.Mobile.Move.performed -= Move_performed;
    }
}
