using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotSpeed;
    [SerializeField] private float controllerDeadZone = 0.1f;
    [SerializeField] private float gamepadRotateSmoothing = 1000f;

    PlayerControls controls;
    Vector2 move;
    Vector2 aim;

    private Vector3 playerVelocity;


    private void Awake()
    {
        controls = new PlayerControls();

        controls.PlayerMovement.Movement.performed += cntxt => move = cntxt.ReadValue<Vector2>();
        controls.PlayerMovement.Movement.canceled += cntxt => move = Vector2.zero;

        //controls.PlayerMovement.Rotate.performed += cntxt => rot = cntxt.ReadValue<Vector2>();
        //controls.PlayerMovement.Rotate.canceled += cntxt => rot = Vector2.zero;
    }



    // Update is called once per frame
    void Update()
    {
        Vector3 m = new Vector3(move.x * speed, 0, move.y * speed);

        GetComponent<Rigidbody>().velocity = m;

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
