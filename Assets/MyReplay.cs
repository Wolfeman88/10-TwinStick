using UnityEngine;
using System.Collections;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

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
