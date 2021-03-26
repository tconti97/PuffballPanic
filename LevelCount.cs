using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCount : MonoBehaviour 
{
	public static int levels;
	public static int currentLevel;

	void OnAwake()
	{
		levels=1;
		currentLevel=0;
		GameObject[] objs = GameObject.FindGameObjectsWithTag("LevelCount");
		if(objs.Length > 1)
		{
			Destroy(this.gameObject);
		}
		DontDestroyOnLoad(this.gameObject);
	}
}
