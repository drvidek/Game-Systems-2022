using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this will let you search in the Component menu
[AddComponentMenu("RPG Game/Character/Movement")]

//this script requires a character controller
[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    [Header("Character")]
    [Tooltip("this will apply movement in the world space")]
    public Vector3 moveDir; //this will apply movement in the world space
    public CharacterController charCon;
    public Vector2 input;

    [Header("Speeds")]
    public float speed = 5f;
    public float walkSpeed = 5f, crouchSpeed = 2.5f, runSpeed = 10f;
    public float jumpSpeed = 5f, gravity = 20f;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        charCon = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gamePlayState == GamePlayStates.Game)
        {


            #region Axis Movement
            /*
            //if our character is grounded
            if (charCon.isGrounded)
            {
                //set moveDir to movement direction
                moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                //moveDir is set to the relative player direction
                moveDir = transform.TransformDirection(moveDir);
                //multiply moveDir by speed
                moveDir *= speed;
                //if jump is pressed, jump
                if (Input.GetButton("Jump"))
                {
                    //moveDir.y should equal jump keys
                    moveDir.y += jumpSpeed;

                }

            }*/
            #endregion

            #region Keybinds Input
            if (charCon.isGrounded)
            {
                //A ? is a Ternary Conditional Operator
                //Allows us to evaluate a boolean expression and return results based on which expression is met
                //You can also return a catch all default value if neither are met
                
                input.y = Input.GetKey(KeyBinds.keys["Forward"]) ? 1 : Input.GetKey(KeyBinds.keys["Backwards"]) ? -1 : 0;
                input.x = Input.GetKey(KeyBinds.keys["Right"]) ? 1 : Input.GetKey(KeyBinds.keys["Left"]) ? -1 : 0;
                speed = Input.GetKey(KeyBinds.keys["Sprint"]) ? runSpeed : Input.GetKey(KeyBinds.keys["Crouch"]) ? crouchSpeed : walkSpeed;
                moveDir = transform.TransformDirection(new Vector3(input.x, moveDir.y, input.y));
                moveDir.x *= speed;
                moveDir.z *= speed;
                moveDir.y = Input.GetKey(KeyBinds.keys["Jump"]) ? jumpSpeed : moveDir.y;
            }
            #endregion

            //no matter what
            //gravity
            moveDir.y -= gravity * Time.deltaTime;

            charCon.Move(moveDir * Time.deltaTime);
        }
    }
}
