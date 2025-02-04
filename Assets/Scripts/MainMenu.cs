﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void Play ()
    {
        SceneManager.LoadScene("LevelSelect");
	}
	
	public void Quit ()
    {
        Debug.Log("Exiting...");
        Application.Quit();
	}

    public void ResetGame ()
    {
        PlayerPrefs.DeleteAll();
    }
}
