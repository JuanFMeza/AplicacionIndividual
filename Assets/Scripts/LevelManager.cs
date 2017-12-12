using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	private Playercontroller player;

//	public GameObject deathParticle;
//	public GameObject respawnParticle;
//	public float respawnDelay;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType <Playercontroller> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void RespawndPlayer()
	{
	//	Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		Debug.Log ("Reaparecer el Player");

		player.transform.position = currentCheckpoint.transform.position;
	//	Intantiate (respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
	}
}
