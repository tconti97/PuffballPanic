using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour {

    //position where Puffball starts
    public Vector3 startPos;

    //witch positions
    public Vector3 witchPos1;
    public Vector3 witchPos2;

    public GameObject witch1;
    public GameObject witch2;
    public GameObject[] hunters;

    void onTriggerEnter(Collider other)
    {
		Debug.Log("Trigger");
        //hunters put you back at the start of the level
		if (other.gameObject.CompareTag("Hunter"))
        {
			Debug.Log("Hunter");
            transform.position = startPos;
        }
		else if (other.gameObject.CompareTag("Witch1"))
        {
			Debug.Log("Witch1");
            transform.position = witchPos2;
        }
		else if (other.gameObject.CompareTag("Witch2"))
        {
			Debug.Log("Witch2");
            transform.position = witchPos2;
        }
    }

    /*
    private void Update()
    {
        if (this.transform.position == witch1.transform.position)
        {

        }
        else if (this.transform.position == witch2.transform.position)
        {

        }

        for ()
        { 
             if (this.transform.position == hunters[i].transform.position)
             {

             }
        }
    }
    */
   
}
