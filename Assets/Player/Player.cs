using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	private float H, V;

	// Update is called once per frame
	void Update () 
	{
		H = CrossPlatformInputManager.GetAxis ("Horizontal"); 
		V = CrossPlatformInputManager.GetAxis ("Vertical");
	}
}
