using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour {

    bool chop;
    bool playChop;
    Animator chopAnim;
	//bool state=false;
	public float maxRotation;
	public float speed;
	public float initialRotation;


	// Use this for initialization
	void Start ()
    {
        //StartCoroutine(WaitForChop());
        chopAnim = gameObject.GetComponent<Animator>();
        playChop = true;
        chop = false;
    }
	/*
	IEnumerator WaitForChop()
    {
        chop = true;
        //chopAnim.Play("Knight_Chop");
       // yield return new WaitForSeconds(seconds);
		//chopAnim.StopPlayback();
		chop = false;
    }
*/
	// Update is called once per frame
	void Update ()
    {
		
		transform.rotation = Quaternion.Euler(0f, initialRotation + maxRotation* Mathf.Sin(Time.time *speed), 0f);

		if(Mathf.Abs(transform.rotation.y - initialRotation) >= 40f)
		{
			gameObject.GetComponent<BoxCollider>().enabled = true;
		}
		else 
		{
			gameObject.GetComponent<BoxCollider>().enabled = false;
		}

        if (playChop)
        {
            playChop = false;
           // WaitForChop();
        }
        else
        {
            playChop = true;
        }
	}
}
