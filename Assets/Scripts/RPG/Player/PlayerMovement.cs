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

    [Header("Speeds")]
    public float speed = 5f;
    public float jumpspeed = 5f, gravity = 20f;
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
                    moveDir.y += jumpspeed;

                }

            }

            //no matter what
            //gravity
            moveDir.y -= gravity * Time.deltaTime;

            charCon.Move(moveDir * Time.deltaTime);
        }
    }
}
