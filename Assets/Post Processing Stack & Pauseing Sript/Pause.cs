﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if player hit Space key Pause the Game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0f;
        }
        //if player hit the R key resume the game
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
        }

    }
}
