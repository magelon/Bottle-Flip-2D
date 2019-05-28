/*
 * code by guojin dong may 29 2019
 * bottle img reference
 * https://opengameart.org/content/bottle-icons
 * 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFlip : MonoBehaviour
{
    public GameObject bottle;
    Rigidbody2D bottleBody;

    [Range(500,1000)]
    public float thrust;

    [Range(200, 1000)]
    public float torque;

    //velocity on bottle
    [SerializeField]
    private float ve;

    [Range(0,5)]
    public float offset;

    public int jumpCount = 0;

    void Start()
    {
        bottleBody = bottle.GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    private void Update()
    {
        //check ve
        ve = bottleBody.velocity.magnitude;

        if (Input.GetMouseButtonDown(0))
        {
            jumpCount++;
        }

    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0)&&(jumpCount<2))
        {
            //to avoid the collision detection and jump at same time 
            //change jump position a little bit above
            bottle.transform.position = new Vector2(bottle.transform.position.x, bottle.transform.position.y + offset);
            //change bodyType to dynamic
            bottleBody.bodyType = 0;
            //add forward force. don't need if obstacle move
            //bottleBody.AddForce(transform.right * thrust);
            //add upward force
            bottleBody.AddForce(transform.up * thrust);
            //add torque force
            bottleBody.AddTorque(torque);
        }
    }
}
