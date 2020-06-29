﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Invoke("switchScene", 0);
            Debug.Log("A key or mouse click has been detected");
        }
    }

    void switchScene()
    {

        StateManager.Instance.SwitchState(StateManager.Instance.mainSceneState);

    }
    
}