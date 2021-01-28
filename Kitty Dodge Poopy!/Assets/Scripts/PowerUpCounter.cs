using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCounter : MonoBehaviour {


    public int score;
    public static float highscore;
    public PointCounter pointCounter;
    public GameObject doublePointText;
    private bool doublePoints;
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
            if (doublePoints == true)
            {
                score += 2;
                //increments score by 2
                Debug.Log("2 Points (Double Time!)");
            }
            else
            {
                score += 1;
                //increments score by 1
                Debug.Log("1 Points");
            }
        }
        else if (collision.gameObject.tag == "PowerBag")
        {
            if (doublePoints == true)
            {
                score += 4;
                //increments score by 4
                Debug.Log("4 Points (Double Time!)");
            }
            else
            {
                score += 2;
                //increments score by 2
                Debug.Log("2 Points!");
            }
        }
        else if (collision.gameObject.tag == "PizzaPower")
        {
            if (doublePoints == true)
            {
                score += 10;
                //increments score by 2
                Debug.Log("10 Points (Double Time!)");
            }
            else
            {
                score += 5;
                //increments score by 3
                Debug.Log("3 Points!");
            }
        }
        else if (collision.gameObject.tag == "TimesTwo")
        {
            StartCoroutine(Timestwotime());
        }
    }
    IEnumerator Timestwotime()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Double Points at timestamp : " + Time.time);
        doublePoints = true;
        doublePointText.SetActive(true);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);
        doublePoints = false;
        doublePointText.SetActive(false);
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Double Points at timestamp : " + Time.time);

    }
}
