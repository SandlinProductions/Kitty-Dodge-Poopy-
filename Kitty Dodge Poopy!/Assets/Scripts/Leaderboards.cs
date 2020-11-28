using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine;

public class Leaderboards : MonoBehaviour {

	// Logs player in at Start of game
	void Start () {
		Social.localUser.Authenticate((bool success) =>
			{
				if (success)
				{
					Debug.Log("You've successfully logged in");
				}
				else
				{
					Debug.Log("Login failed for some reason");
				}
			});
	}
}
