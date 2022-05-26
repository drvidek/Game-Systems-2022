using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : Stats
{
    public static PlayerHandler playerHandlerInstance;

    private void Awake()
    {
        if (playerHandlerInstance != null && playerHandlerInstance != this)
            Destroy(this);
        else
            playerHandlerInstance = this;
    }
}
