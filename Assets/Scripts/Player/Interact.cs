using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[AddComponentMenu("RPG Game/Character/Interact")]
public class Interact : MonoBehaviour
{
    //Ray - an infinite line starting at origin and going in direction (a struct)
    //Raycasting - cast a ray, from point origin, in direction dir, of length maxDist, against all colliders
    //Raycasthit - struct used to get information back from the raycast
    void Update()
    {
        //if interact is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            //create ray - this is our line, it has no direction or origin yet
            Ray interact;

            //this is the ray shooting out from the centre of the screen based on the camera
            interact = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //create the information from the rayhit
            RaycastHit hitInfo;

            //if you hit something within 10units
            if (Physics.Raycast(interact, out hitInfo, 10))
            {
                #region NPC
                if (hitInfo.collider.tag == "NPC")
                {
                    Debug.Log("NPC");
                }

                #endregion

                #region Item
                if (hitInfo.collider.CompareTag("Item"))
                {
                    Debug.Log("Item");
                }
                #endregion

                #region Chest
                if (hitInfo.collider.CompareTag("Chest"))
                {
                    Debug.Log("Chest");
                }
                #endregion
            }

        }
    }

    private void OnGUI()
    {
        //GUI.Box(new Rect(GameManager.scr.x * 16/2, GameManager.scr.y * 9/2, GameManager.scr.x * 0.25f, GameManager.scr.y * 0.25f), "");
        GUI.Box(new Rect(Screen.width/2 - (GameManager.scr.x * 0.2f)/2, Screen.height / 2 - (GameManager.scr.x * 0.2f) / 2, GameManager.scr.x * 0.2f, GameManager.scr.y * 0.2f), " " );
    }
}
