using UnityEngine;
using System.Collections;

public class ReplaySystem : MonoBehaviour {
	
	private const int bufferSize = 1000;
	private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferSize];

	private Rigidbody rigidBody;
	private GameManager gameManager;

	// Use this for initialization
	void Start () 
	{
		rigidBody = GetComponent<Rigidbody> ();
		gameManager = FindObjectOfType<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameManager.bIsRecording)
		{
			Record ();
		}
		else
		{
			PlayBack ();
		}
	}

	private void Record ()
	{
		rigidBody.isKinematic = false;
		int frame = Time.frameCount % bufferSize;
		float time = Time.time;

		Debug.Log ("Writing frame " + frame);

		keyFrames [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
	}

	private void PlayBack ()
	{
		rigidBody.isKinematic = true;
		int frame = Time.frameCount % bufferSize;

		Debug.Log ("Reading frame " + frame);

		transform.position = keyFrames [frame].fPosition_OfObjectAtTimeOfOccurrence;
		transform.rotation = keyFrames [frame].fRotation_OfObjectAtTimeOfOccurrence;
	}
}

/// <summary>
/// Structure for storing time, rotation and position
/// </summary>
public class MyKeyFrame 
{
	public float fTimeOfOccurrence = 0f;
	public Vector3 fPosition_OfObjectAtTimeOfOccurrence = Vector3.zero;
	public Quaternion fRotation_OfObjectAtTimeOfOccurrence = Quaternion.identity;


	public MyKeyFrame (float time, Vector3 position, Quaternion rotation)
	{
		fTimeOfOccurrence = time;
		fPosition_OfObjectAtTimeOfOccurrence = position;
		fRotation_OfObjectAtTimeOfOccurrence = rotation;
	}
}
