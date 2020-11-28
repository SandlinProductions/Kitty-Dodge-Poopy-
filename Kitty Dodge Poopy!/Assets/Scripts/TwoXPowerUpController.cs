using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoXPowerUpController : MonoBehaviour {

	public int score;
	public static float highscore;
	public PointCounter pointCounter;
	// Use this for initialization
	void Start()
	{
		score = 0;
		highscore = PlayerPrefs.GetFloat("BestKitties");
	}

	// Update is called once per frame
	void Update()
	{
		if (score > highscore)
		{
			highscore = score;
			PlayerPrefs.SetFloat("BestKitties", score);
		}
	}

	//checks for entering a trigger
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//checks collider's tag
		if (collision.gameObject.tag == "PowerUp")
		{
			score += 2;
			//increments score by 1
			Debug.Log("2 Points");
		}
		else if (collision.gameObject.tag == "PowerBag")
		{
			score += 4;
			//increments score by 2
			Debug.Log("4 Points!");
		}
		else if (collision.gameObject.tag == "PizzaPower")
		{
			score += 6;
			//increments score by 3
			Debug.Log("6 Points!");
		}
	}
}
