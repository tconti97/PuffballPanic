using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour {

	public Transform[] dogMove;
	public GameManager GM;

	public int currentPt;
	public float moveSpeed;
	public bool triggered;
	public bool atPoint;

	void Start ()
	{
		transform.position = dogMove[0].position;
		currentPt = 0;
		triggered=false;
		atPoint=false;
	}

	void Update ()
	{
		if (GM.isPaused == false && triggered==true)
		{
			//reached current point
			if (transform.position == dogMove[currentPt].position)
				currentPt++;

			//go back to 0 at the end
			if (currentPt >= dogMove.Length)
			{
				currentPt = 0;
				//atPoint=false;
			}

			//move dog
			transform.position = Vector3.MoveTowards(transform.position,
				dogMove[currentPt].position,
				moveSpeed * Time.deltaTime);

			if(dogMove[0].position==this.transform.position)
			{
				triggered=false;
			}
		}

	}
}
