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

		if (Mathf.Abs (H) > 0.1f)
		{
			Debug.Log ("H: " + H.ToString ());
		}

		if (Mathf.Abs (V) > 0.1f)
		{
			Debug.Log ("V: " + V.ToString ());
		}
	}
}
