using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour 
{
	private const int STEP=1;
/*	public int x;
	public int z;
	public int prevX;
	public int prevZ;

	public int startX;
	public int startZ;
*/
	UnityEngine.AI.NavMeshAgent agent;
    public SceneController SC;

    //position where Puffball starts
    public GameObject startPos;

	//witch positions
	public GameObject witchPos1;
	public GameObject witchPos2;
/*	public int witch1X;
	public int witch1Z;
	public int witch2X;
	public int witch2Z;
	*/

	bool frozen = false; //Let it Go

	void Start () 
	{
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		/*x = startX;
		z = startZ;
		prevX=x;
		prevZ=z;*/
	}

	IEnumerator FreezePlayer()
	{
		Debug.Log(Time.time);
		yield return new WaitForSeconds(2);
		Debug.Log(Time.time);
		frozen=false;
	}

	void Update ()
	{
		this.transform.eulerAngles = new Vector3(-90, transform.eulerAngles.y, transform.eulerAngles.z);
		this.transform.position = new Vector3(this.transform.position.x, 5.07f, this.transform.position.z);

		if (frozen) 
		{
			StartCoroutine(FreezePlayer());
		}
		else
		{
			if (/*z<11 &&*/ Input.GetKeyDown (KeyCode.W)) 
			{
				//move forward 
				this.transform.position = new Vector3(this.transform.position.x, 
					this.transform.position.y, this.transform.position.z+1.68f);
				/*prevX=x;
				prevZ=z;
				z++;*/
			}
			else if (/*x<11 && */Input.GetKeyDown (KeyCode.A)) 
			{
				//move left
				this.transform.position = new Vector3(this.transform.position.x-1.68f, 
					this.transform.position.y, this.transform.position.z);
				/*prevX=x;
				prevZ=z;
				x++;*/
			}
			else if (/*z>0 && */Input.GetKeyDown (KeyCode.S)) 
			{
				//move back
				this.transform.position = new Vector3(this.transform.position.x, 
					this.transform.position.y, this.transform.position.z-1.68f);
				/*prevX=x;
				prevZ=z;
				z--;*/
			} 
			else if (/*x>0 &&*/ Input.GetKeyDown (KeyCode.D)) 
			{
				//move right
				this.transform.position = new Vector3(this.transform.position.x+1.68f, 
					this.transform.position.y, this.transform.position.z);
				/*prevX=x;
				prevZ=z;
				x--;*/
				} 
		}

	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Trigger");
        //hunters put you back at the start of the level
        if (other.gameObject.CompareTag("Hunter"))
        {
            Debug.Log("Hunter");
			agent.Warp(startPos.transform.position);
            //transform.position = startPos.transform.position;
          /*  x = startX;
			z = startZ;*/
        }
        else if (other.gameObject.CompareTag("Witch1"))
        {
            Debug.Log("Witch1");
			agent.Warp(witchPos2.transform.position);
            //transform.position = witchPos2.transform.position;
			/*x = witch1X;
			z = witch1Z;
			prevX=x;
			prevZ=z;*/
        }
        else if (other.gameObject.CompareTag("Witch2"))
        {
            Debug.Log("Witch2");
			agent.Warp(witchPos1.transform.position);
            //transform.position = witchPos1.transform.position;
			/*x = witch2X;
			z = witch2Z;
			prevX=x;
			prevZ=z;*/
        }
		else if(other.gameObject.CompareTag("Dog"))
		{
			Debug.Log("Dog");
			agent.Warp(startPos.transform.position);
			//transform.position = startPos.transform.position;
			/*x = startX;
			z = startZ;
			prevX=x;
			prevZ=z;*/
		}
        else if (other.gameObject.CompareTag("Door"))
        {
			SC.toWinScreen();
        }
		else if(other.gameObject.CompareTag("Knight"))
		{
			Debug.Log("Knight");
			frozen=true;
		}
        else if (other.gameObject.CompareTag("Zombie"))
        {
            Debug.Log("Zombie");
            frozen = true;
        }
        else if(other.gameObject.CompareTag("Fence"))
		{
			/*if(x==prevX)
			{
				if(z>prevZ)
				{
					this.transform.position = new Vector3(this.transform.position.x, 
						this.transform.position.y, this.transform.position.z-1.68f);
					z--;
				}
				else //z<prevZ
				{
					this.transform.position = new Vector3(this.transform.position.x, 
						this.transform.position.y, this.transform.position.z+1.68f);
					z++;
				}
			} 
			else //z==prevZ
			{
				if(x>prevX)
				{
					this.transform.position = new Vector3(this.transform.position.x+1.68f, 
						this.transform.position.y, this.transform.position.z);
					x--;
				}
				else //x<prevX
				{
					this.transform.position = new Vector3(this.transform.position.x-1.68f, 
						this.transform.position.y, this.transform.position.z);
					x++;
				}
			}
			prevX=x;
			prevZ=z;*/
		}
    }
}
