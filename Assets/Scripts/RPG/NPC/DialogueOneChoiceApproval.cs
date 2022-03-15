using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOneChoiceApproval : DialogueOneChoice
{

    [Header("How much the NPC likes us")]
    public int approval;

    [Header("The Dialogue based on approval")]
    public string[] likeText;
    public string[] dislikeText;
    public string[] neutralText;


    private void Start()
    {
        approval = 0;
        text = neutralText;
    }

    void OnGUI()
    {
        int approvalOld = approval;

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

                //if yes, they like you more and change what we are reading from

                //if no, they like you less and change what we are reading from, and skip to last like

                if (GUI.Button(new Rect(GameManager.scr.x * 14, GameManager.scr.y * 8.5f, GameManager.scr.x, GameManager.scr.y / 2), "Yes"))
                {
                    index++;
                    approval++;
                }
                if (GUI.Button(new Rect(GameManager.scr.x * 15, GameManager.scr.y * 8.5f, GameManager.scr.x, GameManager.scr.y / 2), "No"))
                {
                    index = text.Length - 1;
                    approval--;
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

            approval = Mathf.Clamp(approval, -1, 1);

            if (approval != approvalOld)
            {
                if (approval == -1)
                    text = dislikeText;
                else
                if (approval == 0)
                    text = neutralText;
                else
                if (approval == 1)
                    text = likeText;
            }
            
        }
    }
}
