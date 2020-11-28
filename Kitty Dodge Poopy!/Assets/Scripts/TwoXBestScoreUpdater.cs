using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoXBestScoreUpdater : MonoBehaviour {
	Text text;
	public TwoXPowerUpController highscore;

	// Use this for initialization

	void Start()
	{

		text = gameObject.GetComponent<Text>();

	}



	// Update is called once per frame

	void Update()
	{

		text.text = "Best: " + TwoXPowerUpController.highscore.ToString();


	}


}