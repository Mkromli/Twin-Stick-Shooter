using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float originalSpeed;
    [SerializeField] private float dashSpeed;
    [SerializeField] private float rotSpeed;
    [SerializeField] private float controllerDeadZone = 0.1f;
    [SerializeField] private float gamepadRotateSmoothing = 1000f;
    [SerializeField] private int dashLength = 300;
    [SerializeField] private int dashCooldownLength = 1800;

    PlayerControls controls;
    Vector2 move;
    Vector2 aim;

    private float speed;
    private Vector3 playerVelocity;
    
    private bool dashTimerStart = false;
    private bool dashCooldownStart = false;
    private int dashTimer;
    private int dashCooldown;
    private bool dashButtonPressed;

    private GameObject player;


    private void Awake()
    {
        controls = new PlayerControls();
        speed = originalSpeed;
        
        controls.PlayerMovement.Movement.performed += cntxt => move = cntxt.ReadValue<Vector2>();
        controls.PlayerMovement.Movement.canceled += cntxt => move = Vector2.zero;

        controls.PlayerMovement.Dash.performed += cntxt => dashButtonPressed = true;
        controls.PlayerMovement.Dash.canceled += cntxt => dashButtonPressed = false;


        //This is tank controls that i had before, if we want  to we can make this an option in gameplay.
        //controls.PlayerMovement.Rotate.performed += cntxt => rot = cntxt.ReadValue<Vector2>();
        //controls.PlayerMovement.Rotate.canceled += cntxt => rot = Vector2.zero;
    }



    // Update is called once per frame
    void Update()
    {
        Vector3 m = new Vector3(move.x * speed, 0, move.y * speed);

        GetComponent<Rigidbody>().velocity = m;

        //BEHOLD, THE DASH-INATOR!!!
        if (dashButtonPressed == true)
        {
            if (dashCooldownStart == false)
            {
                if (dashTimerStart == false)
                {
                    speed = dashSpeed;
                    dashTimerStart = true;
                    player = GameObject.Find("Player");
                    player.GetComponent<Rigidbody>().useGravity = false;
                }
            }
        }

        if (dashTimerStart == true)
        {
            dashTimer += 1;
            if (dashTimer >= dashLength)
            {
                dashTimerStart = false;
                dashCooldownStart = true;
                dashTimer = 0;
                speed = originalSpeed;
                player = GameObject.Find("Player");
                player.GetComponent<Rigidbody>().useGravity = true;
            }

        }

        if (dashCooldownStart == true)
        {
            dashCooldown += 1;
            if (dashCooldown >= dashCooldownLength)
            {
                dashCooldownStart = false;
                dashCooldown = 0;
            }

        }


        HandleInput();
        HandleRotation();

       // GetComponent<Transform>().Rotate(Vector3.up * rot.x * rotSpeed);
    }

    private void OnEnable()
    {
        controls.PlayerMovement.Enable();
    }

    private void OnDisable()
    {
        controls.PlayerMovement.Disable();
    }


    //the tutorial told me to put this here so its here, im assuming it just checks the direction the stick is aiming but dont know for sure.
    void HandleInput()
    {
        aim = controls.PlayerMovement.Rotate.ReadValue<Vector2>();


    }

    //Makes the player rotate in the direction the stick is aiming
    void HandleRotation()
    {

        if (Mathf.Abs(aim.x) > controllerDeadZone || Mathf.Abs(aim.y) > controllerDeadZone)
        {
            Vector3 playerDirection = Vector3.right * aim.x + Vector3.forward * aim.y;
            if (playerDirection.sqrMagnitude > 0.0f)
            {
                Quaternion newrotation = Quaternion.LookRotation(playerDirection, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, newrotation, gamepadRotateSmoothing * Time.deltaTime);


            }

        }
            

    }



}
