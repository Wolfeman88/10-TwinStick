using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	const float MAX_DIFFICULTY = 3.0f;

	public static void SetMasterVolume (float volume)
	{
		if (volume >= 0f && volume <= 1f)
		{
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		}
		else
		{
			Debug.LogError ("Master Volume Out of Range");
		}
	}

	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel (int level)
	{
		if (level <= (SceneManager.sceneCountInBuildSettings - 1))
		{
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1);	// use 1 for true
		}
		else
		{
			Debug.LogError ("Trying to unlock level not in build order");
		}
	}

	public static bool IsLevelUnlocked (int level)
	{
		bool Check = false;

		if (level <= (SceneManager.sceneCountInBuildSettings - 1))
		{
			int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
			Check = levelValue == 1;
		}
		else
		{
			Debug.LogError ("Searching for level not in build order");
		}
			
		return Check;
	}

	public static void SetDifficulty (float diff)
	{
		if (diff >= 1.0f && diff <= MAX_DIFFICULTY)
		{
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, diff);
		}
		else
		{
			Debug.LogError ("Not a valid difficulty.");
		}
	}

	public static float GetDifficulty ()
	{
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}
}
