﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
      
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
