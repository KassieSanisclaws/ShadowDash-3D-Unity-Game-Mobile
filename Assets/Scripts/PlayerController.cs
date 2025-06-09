using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 moveDirection;
    public float speed = 5f;
    public float jumpForce = 15f;
    private int lane = 1; // 0 = Left, 1 = Middle, 2 = Right
    public float laneDistance = 4f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection.z = speed;

        if (characterController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) moveDirection.y = jumpForce;
        }

        moveDirection.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
}
}
