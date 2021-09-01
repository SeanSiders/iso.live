using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //// PUBLIC MEMBERS

    //Player movement speed, 1.0f is 1 unit of translation per delta second
    public float moveSpeed = 0.3f;

    //Reference to the player's following camera
    new public Camera camera; // must be new due to the deprecated Component.camera
    public float camSmoothTime = 0.2f;

    //// PRIVATE MEMBERS

    private PlayerInputActions playerInputActions;
    private InputAction movement;
    private Vector2 move;

    private Vector3 cameraOffset;
    private Vector3 cameraVelocity = Vector3.zero;

    private Animator animator;

    private void Start()
    {
        //Get the intial camera offset with respect to the parent "Player" object
        cameraOffset = camera.transform.localPosition;
        animator = GetComponent<Animator>();

        //This flag is used to detect movement for the animator
        //The first frame will have this be true by default which is not desired
        transform.hasChanged = false;
    }

    private void Awake()
    {
        //Instance of |PlayerInputActions| in |Assets/Input|
        playerInputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        movement = playerInputActions.Player.Move;
        movement.Enable();

        //playerInputActions.Jump.performed += OnJump;
        //playerInputActions.Jump.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    private void Update()
    {
    }

    //Called on a reliable timer based off of |Time.deltaTime|
    private void FixedUpdate()
    {
        move = movement.ReadValue<Vector2>() * moveSpeed;
        transform.Translate(move.x, move.y, 0.0f);

        //If movment has occured
        if (transform.hasChanged)
        {
            //Branch to the movement anims
            animator.SetBool("IsMoving", true);
            transform.hasChanged = false;
        }
        else animator.SetBool("IsMoving", false);

        //Calculate the new camera position from the player's world position
        Vector3 newCameraPosition = transform.TransformPoint(cameraOffset);

        //Apply smooth camera follow with lag based off of |camSmoothTime|
        camera.transform.position = Vector3.SmoothDamp(camera.transform.position, newCameraPosition, ref cameraVelocity, camSmoothTime);
    }

    //Called after |Update()| and |FixedUpdate()|
    private void LateUpdate()
    {
    }
}