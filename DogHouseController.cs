using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogHouseController : MonoBehaviour 
{
	public GameManager GM;
	public GameObject dog;

	public int currentPt;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			dog.GetComponent<DogController>().triggered=true;
		}
	}
}
