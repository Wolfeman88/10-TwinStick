using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class SelfieStick : MonoBehaviour {

	public float panSpeed = 10f;

	private GameObject playerCharacter;
	private Vector3 armRotation;

	// Use this for initialization
	void Start () 
	{
		playerCharacter = GameObject.FindGameObjectWithTag ("Player");
		armRotation = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () 
	{
		armRotation.y += CrossPlatformInputManager.GetAxis ("RHoriz") * panSpeed;
		armRotation.x += CrossPlatformInputManager.GetAxis ("RVert") * panSpeed;

		transform.position = playerCharacter.transform.position;
		transform.rotation = Quaternion.Euler (armRotation);
	}
}
