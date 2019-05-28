/* attache this script on the buttle bottom
 * to detect land on the floor or not
 * using ontriggerenter not working as I want so easy to detect on triggerEnter
 * 
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFloor : MonoBehaviour
{
    public GameObject bottle;
    public GameObject gameManager;

    JumpFlip jumpflip;

    private void Start()
    {
        jumpflip = gameManager.GetComponent<JumpFlip>();

    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Respawn")
        {
            //set bottle stand position and zero velocity

            bottle.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            bottle.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            bottle.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
    */

    private void OnCollisionEnter2D(Collision2D collision)
    {                                   //use build in reapwan tag as land
        if (collision.gameObject.tag == "Respawn")
        {
            //set bottle stand position and zero velocity

            bottle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            bottle.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            bottle.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

            jumpflip.jumpCount = 0;
        }
    }


}
