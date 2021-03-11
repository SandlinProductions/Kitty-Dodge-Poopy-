using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    //Speed of Enemy
    public float speed = 8f;
    public AudioClip hitSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Movemnet of Enemy
        transform.Translate(0, -speed * Time.deltaTime, 0);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checks if other gameobject has a Tag of Player
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().alive = false;
            AudioSource.PlayClipAtPoint(hitSound, new Vector3(0,0,-10));
            //Pauses gameplay
            Time.timeScale = 0;
        }
    }
}
