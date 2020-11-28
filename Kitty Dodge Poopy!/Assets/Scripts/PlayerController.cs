using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public bool alive;
    //Which way the Player is Facing
    public bool facingRight = true;
    //Speed of the Player
    public float speed = 10.0f;

    //Bounds of Player
    public float leftBound = -5f;
    public float rightBound = 5f;
	// Use this for initialization
	void Start () {
        alive = true;
    }
	
	// Update is called once per frame
	void Update () {
        
        //Horizontal Speed
        float movementSpeedX = Time.deltaTime * Input.GetAxis("Horizontal") * speed;
        //Vertical Speed
        // If the input is moving the player right and the player is facing left...
        if (movementSpeedX > 0 && !facingRight)
            // ... flip the player.
            Flip();
        else if (movementSpeedX < 0 && facingRight)
            // ... flip the player.
            Flip();

        //Player Movement
        transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
        transform.Translate(movementSpeedX, 0, 0);
        // If the input is moving the player right and the player is facing left...
        if (Input.acceleration.x > 0 && !facingRight)
            // ... flip the player.
            Flip();
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (Input.acceleration.x < 0 && facingRight)
            // ... flip the player.
            Flip();

        //Creates bounds around player
        if (transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, 0);
        }
        else if (transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, 0);
        }
    }

    void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
