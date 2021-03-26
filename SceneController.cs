using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour 
{
    //public Scene main;
    //public Button btn1;
    //public Button btn2;
    public int sceneNum;

	void Start()
	{
        //main = SceneManager.GetSceneByName("MainMenu");
        sceneNum = 0;
		//GameObject level = GameObject.Find("LevelCount");
	}

    //called in PlayerController when the door is reached
    //unlocking scenes can be put in here later
    public void LevelComplete()
    {
		Debug.Log("Levels: " + LevelCount.levels + "/nCurrent: " + LevelCount.currentLevel);
		if(LevelCount.levels <= LevelCount.currentLevel) {LevelCount.levels = LevelCount.levels + 1 ;}
        if (LevelCount.currentLevel == 1)
        {
            toLevel2();
        }
        else if (LevelCount.currentLevel == 2)
        {
            toLevel3();
        }
        else if (LevelCount.currentLevel == 3)
        {
            toLevel4();
        }
        else if (LevelCount.currentLevel == 4)
        {
            toLevel5();
        }
        else if (LevelCount.currentLevel == 5)
        {
            toLevel6();
        }
        else if (LevelCount.currentLevel == 6)
        {
            toLevel7();
        }
        else if (LevelCount.currentLevel == 7)
        {
            toLevel8();
        }
        else if (LevelCount.currentLevel == 8)
        {
            toLevel9();
        }
        else if (LevelCount.currentLevel == 9)
        {
            toLevel10();
        }
        else if (LevelCount.currentLevel == 10)
        {
            SceneManager.LoadScene("WinScreen10");
        }
    }

    public void toMain()
	{
		Debug.Log("Levels: " + LevelCount.levels + "/nCurrent: " + LevelCount.currentLevel);
		SceneManager.LoadScene("MainMenu");
	}

	public void toLevel1()
	{
		LevelCount.currentLevel = 1;
		Debug.Log("Levels: " + LevelCount.levels + "/nCurrent: " + LevelCount.currentLevel);
		SceneManager.LoadScene("Level_01");
	}

	public void toLevel2()
	{
		LevelCount.currentLevel = 2;
		Debug.Log("Levels: " + LevelCount.levels + "/nCurrent: " + LevelCount.currentLevel);
		SceneManager.LoadScene("Level_02");
	}

	public void toLevel3()
	{
		LevelCount.currentLevel = 3;
		Debug.Log("Levels: " + LevelCount.levels + "/nCurrent: " + LevelCount.currentLevel);
		SceneManager.LoadScene("Level_03");
	}

	public void toLevel4()
	{
		LevelCount.currentLevel = 4;
		SceneManager.LoadScene("Level_04");
	}

	public void toLevel5()
	{
		LevelCount.currentLevel = 5;
		SceneManager.LoadScene("Level_05");
	}

    public void toLevel6()
    {
		LevelCount.currentLevel = 6;
        SceneManager.LoadScene("Level_06");
    }

    public void toLevel7()
    {
		LevelCount.currentLevel = 7;
        SceneManager.LoadScene("Level_07");
    }

    public void toLevel8()
    {
		LevelCount.currentLevel = 8;
        SceneManager.LoadScene("Level_08");
    }

    public void toLevel9()
    {
		LevelCount.currentLevel = 9;
        SceneManager.LoadScene("Level_09");
    }

    public void toLevel10()
    {
		LevelCount.currentLevel = 10;
        SceneManager.LoadScene("Level_10");
    }

    public void toLevelSelect()
	{
		Debug.Log("Levels: " + LevelCount.levels + "/nCurrent: " + LevelCount.currentLevel);
		SceneManager.LoadScene("LevelSelect");
	}
    public void toControls()
    {
        SceneManager.LoadScene("Controls");
    }

	public void toWinScreen()
	{
		Debug.Log("Levels: " + LevelCount.levels + "/nCurrent: " + LevelCount.currentLevel);
		SceneManager.LoadScene("WinScreen");
	}

	public void toCredits()
	{
		SceneManager.LoadScene("CreditsMenu");
	}

	public void Quit()
	{
		Application.Quit();
	}
}
