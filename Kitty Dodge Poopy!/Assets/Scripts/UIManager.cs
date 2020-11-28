using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
    GameObject[] pauseObjects;
    GameObject[] finishObjects;
    PlayerController playerController;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        //gets all objects with tag ShowOnPause
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        //gets all objects with tag ShowOnFinish
        finishObjects = GameObject.FindGameObjectsWithTag("ShowOnFinish");
        hidePaused();
        hideFinished();

        //Checks to make sure Mainlevel is the loaded level
        if (SceneManager.GetActiveScene().name == "MainLevel")
            playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
		//Checks to make sure 2xPoints is the loaded level
		/*if (SceneManager.GetActiveScene ().name == "2xPoints")
			playerController = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
        */
	}

    //Updat is called once per frame
    private void Update()
    {
        //uses the p button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1 && playerController.alive == true)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0 && playerController.alive == true)
            {
                Time.timeScale = 1;
                hidePaused();
            }
        }
        //shows finish gameObjects if player is dead and timescale = 0
        if(Time.timeScale == 0 && playerController.alive == false)
        {
            showFinished();
        }
        
    }
    //Reloads the Level
    public void Reload()
    {
        SceneManager.LoadScene("MainLevel");
    }
    //controls the pausing of the scene
    public void pauseControl()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }
    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }
    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
    //shows objects with ShowOnFinish tag
    public void showFinished()
    {
        foreach(GameObject g in finishObjects)
        {
            g.SetActive(true);
        }
    }
    //hids objects with ShowOnFinish tag
    public void hideFinished()
    {
        foreach(GameObject g in finishObjects)
        {
            g.SetActive(false);
        }
    }
    //loads imputted level
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    //Triggering the leadboard
    public void LeaderBoard(int mode)
    {
		Social.ReportScore((int)PlayerPrefs.GetFloat("BestKitties"), "com.SandlinProductions.KittyDodgePoopy.Leaderboard", (bool success) =>
        {
            // handle success or failure
            Debug.Log("new highscore posted");
        });

        Social.ShowLeaderboardUI();
        Debug.Log("Show Leaderboard");
    }

}
