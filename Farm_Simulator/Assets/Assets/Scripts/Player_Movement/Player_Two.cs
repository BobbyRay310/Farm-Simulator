using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class Player_Two : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;

    public GameObject player_2;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private Vector3 movementInput = Vector2.zero;
    private bool jumped = false;

    private void Start() //This gets the Unity Input system
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext context) //This method reads the 2nd player inputs based from "IJKL" keys
    {
        movementInput = context.ReadValue<Vector2>();
    }

    void Update() //This adjusts the players rotation, speed, and gravity.
    {
      /*  groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
      */
        Vector3 move = new Vector3(movementInput.x, 0, movementInput.y); //This changes the position to either go up, down, left, or right
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        if (jumped && groundedPlayer) //This normally is used for platformers for jumping, however this is needed so that the player is able to move otherwise it will stay in place and only change rotations.
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}