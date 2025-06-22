using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    private Vector2 inputMove;

    public float speed = 5f;
    public float jumpForce = 3.0f;
    public float gravity = -9.81f;

    private float verticalVelocity;

    private InputSystem_Actions inputActions;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();

        inputActions.Player.Move.performed += ctx => inputMove = ctx.ReadValue<Vector2>();
        inputActions.Player.Move.canceled += ctx => inputMove = Vector2.zero;

        inputActions.Player.Jump.performed += ctx => Jump();
    }

    private void OnEnable() => inputActions.Player.Enable();
    private void OnDisable() => inputActions.Player.Disable();

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        // Lateral movement
        direction = new Vector3(inputMove.x, 0f, 1f).normalized; // always move forward

        // Apply gravity
        if (controller.isGrounded)
        {
            if (verticalVelocity < 0)
                verticalVelocity = -1f; // keep grounded
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }

        direction.y = verticalVelocity;

        controller.Move(direction * speed * Time.deltaTime);
    }

    private void Jump()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = jumpForce;
        }
    }

}
