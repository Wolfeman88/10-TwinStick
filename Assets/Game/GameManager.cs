using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool bIsRecording = true;

	// Update is called once per frame
	void Update () 
	{
		//bIsRecording = !CrossPlatformInputManager.GetButton ("Fire1");
		Debug.Log (bIsRecording.ToString ());
	}

	public void ToggleRecordingState ()
	{
		bIsRecording = !bIsRecording;
	}
}
