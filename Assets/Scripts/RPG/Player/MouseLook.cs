using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this will let you search in the Component menu
[AddComponentMenu("RPG Game/Character/MouseLook")]

public class MouseLook : MonoBehaviour
{
    public enum rotAxis
    {
        mouseX,
        mouseY
    }

    [Header("Rotation")]
    public rotAxis axis;

    [Header("Sensitivity")]
    [Range(0, 500)]
    public float sensitivity = 300f;
    [Header("Rotation Clamp")]
    public float minY = -60f;
    public float maxY = 60f;
    private float m_rotY;

    public bool invert = false;

    // Start is called before the first frame update
    void Start()
    {
        //lock cursor to the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;
        //hide the cursor from view
        Cursor.visible = false;
        //if there's a rigidbody attached
        if (GetComponent<Rigidbody>())
        {
            //set Rigidbody freezeRotation to true
            GetComponent<Rigidbody>().freezeRotation = true;
        }

        if (GetComponent<Camera>())
            axis = rotAxis.mouseY;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gamePlayState == GamePlayStates.Game)
        {
            #region Mouse X
            //if we are rotating on the X
            if (axis == rotAxis.mouseX)
            {
                //transform the rotation on our game objects Y by our Mouse input Mouse X times X sensitivity
                //x y z
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime, 0);
            }
            #endregion
            else
            #region Mouse Y
            {

                //else we are only rotation on the Y
                //our rotation Y is pulse equals our mouse input for Mouse Y times Y sensitivity

                m_rotY += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

                //the rotation Y is clamped using Mathf and we are clamping the y rotation to the Y min and Y max
                m_rotY = Mathf.Clamp(m_rotY, minY, maxY);
                //transform our local position to the nex vector3 rotaion - y rotaion on the x axis and local euler angle Y on the y axis
                transform.localEulerAngles = new Vector3(-m_rotY, 0, 0);
            }

            #endregion
        }
    }
}
