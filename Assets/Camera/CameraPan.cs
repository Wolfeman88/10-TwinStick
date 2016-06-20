using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {

	private GameObject playerCharacter;

	// Use this for initialization
	void Start () 
	{
		playerCharacter = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.LookAt (playerCharacter.transform);
	}
}
