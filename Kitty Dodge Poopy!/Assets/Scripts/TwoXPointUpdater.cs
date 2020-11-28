using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoXPointUpdater : MonoBehaviour {

	Text text;
	public TwoXPowerUpController powerUpConter;

	// Use this for initialization

	void Start()
	{

		text = gameObject.GetComponent<Text>();

	}



	// Update is called once per frame

	void Update()
	{

		text.text = "Score: " + powerUpConter.score.ToString();


	}


}