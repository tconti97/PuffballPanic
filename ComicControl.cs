using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicControl : MonoBehaviour
{
    //holds all the comic pages
    public GameObject[] comics;
    public int currentPage;

    //to turn off buttons
    public GameObject nextButton;
    public GameObject skipButton;

	// Use this for initialization
	void Start ()
    {
        currentPage = 0;
        comics[currentPage].SetActive(true);
	}

    //go to the next comic
    public void nextComic()
    {
        comics[currentPage].SetActive(false);
        currentPage++;

        //if it's the last comic
        if (currentPage == comics.Length)
        {
            nextButton.SetActive(false);
            skipButton.SetActive(false);
        }
        //if this isnt' the last comic, turn the next one on
        else
        {
            comics[currentPage].SetActive(true);
        }
    }

    //skip all the comics
    //turn all the comic stuff off immediately
    public void skipComic()
    {
        for (int i = 0; i < comics.Length; i++)
        {
            comics[i].SetActive(false);
        }

        nextButton.SetActive(false);
        skipButton.SetActive(false);
    }
}
