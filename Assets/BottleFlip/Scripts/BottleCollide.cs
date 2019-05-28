using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleCollide : MonoBehaviour
{
    public GameObject butt;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Debug.Log("game over");
            //game over
            //butt.SetActive(false);
        }
    }
}
