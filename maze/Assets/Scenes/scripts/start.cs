﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject startScreen;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("startDelay");
    }
    IEnumerator startDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 10;
        while (Time.realtimeSinceStartup < pauseTime) 
            yield return 0;
        startScreen.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
