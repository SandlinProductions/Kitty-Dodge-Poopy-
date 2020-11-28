﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {
    
    //Keeps gameObject alive

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
