using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public int movespeed;
    public Vector3 userDirection = Vector3.right;
    public void Start()
    {

    }


    public void Update()
    {
        Debug.Log(Input.acceleration.x);
        transform.Translate(userDirection * movespeed * Time.deltaTime);

        if (Input.acceleration.x > 0.02)
        {
            Player.GetComponent<Rigidbody2D>().gravityScale = -1;
        }

        else
        {
            Player.GetComponent<Rigidbody2D>().gravityScale = 1;
        }

    }
}