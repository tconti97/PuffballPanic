using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterControler : MonoBehaviour {

    public Transform[] hunterMove;
    public GameManager GM;


    public int currentPt;
    public float moveSpeed;

	void Start ()
    {
        transform.position = hunterMove[0].position;
        transform.rotation = hunterMove[0].rotation;
        currentPt = 0;
	}
	
	void Update ()
    {
        if (GM.isPaused == false)
        {
            //reached current point
            if (transform.position == hunterMove[currentPt].position)
                currentPt++;

            //go back to 0 at the end
            if (currentPt >= hunterMove.Length)
                currentPt = 0;

            //move hunter
            transform.position = Vector3.MoveTowards(transform.position,
                                hunterMove[currentPt].position,
                                moveSpeed * Time.deltaTime);
            //change rotation
            transform.rotation = hunterMove[currentPt].rotation;
            //W:180 A:-90 S:0 D:90
        }
    }
}
