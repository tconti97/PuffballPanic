using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletionTrack : MonoBehaviour {


    //As of 12/12 this does not work and is not implemented


    public int maxLevel = 1;
    public GameObject[] buttons;
    private string lvlCount;
    public GameObject lvlHold;

    public int currentLvl;

    //this should run every scene load, I think/hope
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        //get the scene name cuz it's needy 
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "LevelSelect")
        {
            //find all the buttons
            for (int j = 1; j < 11; j++)
            {
                //get first level
                lvlCount = "LevelButton (" + j + ")";
                currentLvl = j;
                lvlHold = GameObject.Find(lvlCount);
                Debug.Log(lvlHold.name);
                
                buttons[j]= lvlHold;
                Debug.Log("Button" + j + ": " + buttons[j].name);
            }

            for (int i = 1; i < maxLevel; i++)
            {
               // buttons[i].GetComponent<Button>().Interactable;
            }
        }

    }
}
