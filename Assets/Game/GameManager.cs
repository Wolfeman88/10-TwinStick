using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool bIsRecording = true;

	// Update is called once per frame
	void Update () 
	{
		//Debug.Log (bIsRecording.ToString ());
	}

	public void ToggleRecordingState ()
	{
		bIsRecording = !bIsRecording;
	}
}
