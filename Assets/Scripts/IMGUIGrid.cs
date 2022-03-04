using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUIGrid : MonoBehaviour
{
   

    // Update is called once per frame
    void OnGUI()
    {
        for (int x = 0; x < 16; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                GUI.Box(new Rect(GameManager.scr.x * x, GameManager.scr.y * y, GameManager.scr.x, GameManager.scr.y), x + ":" + y);
            }
        }
    }
}
