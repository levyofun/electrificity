﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    bool isPaused = true;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void pauseGame()
    {
        if(isPaused) {
            Time.timeScale = 1;
            isPaused = false;
        } else {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
