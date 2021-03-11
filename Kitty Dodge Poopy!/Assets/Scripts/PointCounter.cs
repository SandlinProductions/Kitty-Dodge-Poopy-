using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{

    public int score;
    public static float highscore;

    // Use this for initialization
    void Start()
    {
        score = 0;
        highscore = PlayerPrefs.GetFloat("highscoretest2");
    }

    // Update is called once per frame
    void Update()
    {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetFloat("highscoretest2", score);
        }
    }

    //checks for entering a trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks collider's tag
        if (collision.gameObject.tag == "Enemy")
        {
            score++;
            //increments score
            Destroy(collision.gameObject);
        }
    }
}