using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    //Speed of PowerUp
    public float speed = 8f;
    public AudioClip powerUp;
    public GameObject powerEffect;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movemnet of PowerUP
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checks if other gameobject has a Tag of Player
        if (collision.gameObject.tag == "Player")
        {
            
            AudioSource.PlayClipAtPoint(powerUp, new Vector3(0, 0, -10));
            Instantiate(powerEffect, transform.position, Quaternion.identity);

        }
    }
}
