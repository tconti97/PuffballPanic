using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	public GameObject player;
	private const int STEP=1;
	//public int x=1;
	//public int z=1;

    public GameObject pauseMenu;
    public bool isPaused = false;
   // public GameObject pauseBG;

	void Start () 
	{
        isPaused = false;
        pauseMenu.SetActive(false);
       // pauseBG.SetActive(false);
	}

	void Update () 
	{
        //open pause menu
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = true;
            pauseMenu.SetActive(true);
            // pauseBG.SetActive(true);
        }
	}


    //pause menu button
   public void resumeLevel()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
       // pauseBG.SetActive(true);
    }

    //pause menu button
    public void restartLevel()
    {
        SceneManager.LoadScene(Application.loadedLevel);
        isPaused = false;
        pauseMenu.SetActive(false);
        //pauseBG.SetActive(true);
    }
}
