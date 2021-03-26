using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour {

    bool grab;
    bool playGrab;
    Animator grabAnim;

    //each arm must be given the CatRigLArm1 on that hand
    public GameObject armMove;
    //when the arm is down
    public Vector3 armDown;

    public Vector3 armCurrent;

    //bool state = false;
    //public float maxRotation;
    //public float speed;
    //public float initialRotation;


    // Use this for initialization
    void Start()
    {
        //StartCoroutine(WaitForChop());
        grabAnim = gameObject.GetComponent<Animator>();
        playGrab = true;
        grab = false;
    }
  
    // Update is called once per frame
    void Update()
    {
        //rather than based on rotation, it should be up or down
        //transform.rotation = Quaternion.Euler(0f, initialRotation + maxRotation * Mathf.Sin(Time.time * speed), 0f);

        armCurrent = new Vector3(armMove.transform.rotation.x, 
            armMove.transform.rotation.y, armMove.transform.rotation.z);


        //if the arm is down, the collider is on
        if (armCurrent.z <= armDown.z)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
        else if (armMove.transform.rotation.z > armDown.z)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }

        if (playGrab)
        {
            playGrab = false;
            // WaitForChop();
        }
        else
        {
            playGrab = true;
        }
    }
}
