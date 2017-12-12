using UnityEngine;
using System.Collections;

public class CoinPickUp : MonoBehaviour {

	public int pointsToAdd;
	 
	void OnTriggerEnter2D (Collider other)
	{
		if (other.GetComponent<Playercontroller> () == null)
		return; 
		
	}

}
