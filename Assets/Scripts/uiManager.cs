using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Play() {
        SceneManager.LoadScene("level1");
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0; // if game is running it will make it pause
        }
        else if(Time.timeScale == 0)
        {
            Time.timeScale = 1; // if game is pause it will make it play
        }

    }
    public void Exit()
    {
        Application.Quit(); // to exit game
    }

}

