using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOneChoice : MonoBehaviour
{
    public string[] text;
    public int index;
    public int choiceIndex;
    public bool showDlg;

    void OnGUI()
    {
        if (showDlg)
        {
            //box
            //entire bottom third of the screen
            GUI.Box(new Rect(0, GameManager.scr.y * (9 / 3) * 2, GameManager.scr.x * 16, GameManager.scr.y * 9), text[index]);

            if (index < text.Length - 1 && index != choiceIndex)   //if this not a choice dialogue
            {
                //button to continue the dialogue
                //on bottom right, half the size of a grid square
                if (GUI.Button(new Rect(GameManager.scr.x * 15, GameManager.scr.y * 8.5f, GameManager.scr.x, GameManager.scr.y / 2), "Next"))
                {
                    index++;
                }
            }
            else
            //if this is a choice dialogue
            if (index == choiceIndex)
            {
                //button to continue the dialogue
                //on bottom right, half the size of a grid square
                if (GUI.Button(new Rect(GameManager.scr.x * 14, GameManager.scr.y * 8.5f, GameManager.scr.x, GameManager.scr.y / 2), "Yes"))
                {
                    index++;
                }
                if (GUI.Button(new Rect(GameManager.scr.x * 15, GameManager.scr.y * 8.5f, GameManager.scr.x, GameManager.scr.y / 2), "No"))
                {
                    index = text.Length - 1;
                }

            }
            else    //we've reached the end of the dialogue
            {
                //button to end the dialogue
                if (GUI.Button(new Rect(GameManager.scr.x * 15, GameManager.scr.y * 8.5f, GameManager.scr.x, GameManager.scr.y / 2), "End"))
                {
                    index = 0;
                    showDlg = false;
                }
            }


        }
    }
}
