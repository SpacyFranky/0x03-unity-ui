using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public variable to store the rigidbody of the player 
    public Rigidbody rb;

    // Public variable to store the movement speed of the gameobject player.
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        // Arrow keys
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }


        // WASD keys
        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }
    }
}
