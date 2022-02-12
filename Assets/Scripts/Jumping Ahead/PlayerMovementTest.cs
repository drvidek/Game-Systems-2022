using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this will let you search in the Component menu
[AddComponentMenu("RPG Game/Character/Movement")]

//this script requires a character controller
[RequireComponent(typeof(CharacterController))]

public class PlayerMovementTest : MonoBehaviour
{
    public enum eState
    {
        walk,
        slide
    }

    #region Variables
    [Header("Character")]
    [Tooltip("this will apply movement in the world space")]
    public Vector3 moveDir; //this will apply movement in the world space
    public CharacterController charCon;

    [Header("Speeds")]
    public float speed = 5f;
    public float runspeed = 7f, jumpspeed = 5f, slidespeed = 12f, gravity = 20f;

    [Header("State")]
    public eState state;

    public bool slideDecay = true;

    public float slideTimerMax = 1f;
    private float slideTimer;

    private Vector3 slideDir;

    public GameObject cam;

    private Vector3 camPos;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        charCon = GetComponent<CharacterController>();
        state = eState.walk;

        camPos = cam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        camPos = transform.position;

        switch (state)
        {
            case eState.walk:
                {
                    //if our character is grounded
                    if (charCon.isGrounded)
                    {
                        float finalSpeed = speed;

                        if (Input.GetButton("Sprint"))
                        {
                            finalSpeed = runspeed;

                        }
                        //set moveDir to movement direction
                        moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                        //moveDir is set to the relative player direction
                        moveDir = transform.TransformDirection(moveDir);

                        //if you press slide
                        if (Input.GetButton("Slide"))
                        {
                            state = eState.slide;
                            moveDir = Vector3.forward;
                            moveDir = transform.TransformDirection(moveDir);
                            slideDir = moveDir;
                            finalSpeed = slidespeed;

                        }

                        //multiply moveDir by speed
                        moveDir *= finalSpeed;

                        //if jump is pressed, jump
                        if (Input.GetButtonDown("Jump"))
                        {
                            //moveDir.y should equal jump keys
                            moveDir.y += jumpspeed;

                        }


                    }
                }
                break;
            case eState.slide:
                {
                    //set slide speed
                    float finalSpeed = slidespeed;
                    if (slideDecay) //check slideDecay to determine friction on or off
                        finalSpeed = slidespeed - ((slidespeed * 0.75f) * (slideTimer / slideTimerMax));

                    //set moveDir to the direction of the slide and multiply by slide speed
                    moveDir = slideDir * finalSpeed;

                    //set the camera bob
                    camPos.y = transform.position.y - 0.5f;

                    //increase timer for sliding
                    slideTimer += 1 * Time.deltaTime;

                    //check if slide is done
                    if (slideTimer >= slideTimerMax)
                    {
                        state = eState.walk;
                        slideTimer = 0;
                    }

                }
                break;
            default:
                break;
        }

        cam.transform.position = camPos;

        //no matter what
        //gravity
        moveDir.y -= gravity * Time.deltaTime;

        charCon.Move(moveDir * Time.deltaTime);


    }
}
