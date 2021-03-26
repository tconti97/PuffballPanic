using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour 
{
	public int buttonNum;

	void Start () 
	{
		this.GetComponent<Button>().enabled=false;
	}

	void Update () 
	{
		if(LevelCount.levels >= buttonNum)
		{
			this.GetComponent<Button>().enabled=true;
		}
    }
}
