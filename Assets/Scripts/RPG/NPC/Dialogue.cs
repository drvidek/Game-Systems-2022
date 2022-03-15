using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [Header("Display dialogue")]
    public string[] text;
    [Header("Index Markers")]
    public int index;
    public bool showDlg;

    void OnGUI()
    {
        if (showDlg)
        {
            //box
            //entire bottom third of the screen
            GUI.Box(new Rect(0, GameManager.scr.y * (9 / 3) * 2, GameManager.scr.x * 16, GameManager.scr.y * 9), text[index]);


            //if we are not at the final piece of dialogue
            if (index < text.Length - 1)
            {
                //button to continue the dialogue
                //on bottom right, half the size of a grid square
                if (GUI.Button(new Rect(GameManager.scr.x * 15, GameManager.scr.y * 8.5f, GameManager.scr.x, GameManager.scr.y / 2), "Next"))
                {
                    index++;
                }

            }
            else    //we've reached the end of the dialogue
            {
                //button to end the dialogue
                if (GUI.Button(new Rect(GameManager.scr.x * 15, GameManager.scr.y * 8.5f, GameManager.scr.x, GameManager.scr.y / 2), "End"))
                {
                    index = 0;
                    showDlg = false;
                    GameManager.gamePlayState = GamePlayStates.Game;
                }
            }


        }
    }
}
