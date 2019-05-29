using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    JumpFlip jf;
    public Transform[] position;
    public GameObject platform;

    void Start()
    {
        jf = GetComponent<JumpFlip>();
    }

    void Update()
    {
        if (jf.time!=0&&jf.time % 1000==0)
        {
            if(Random.Range(0, 2) > 1)
            {
                Instantiate(platform, position[1].position, Quaternion.identity);
            }
            else
            {
                Instantiate(platform, position[0].position, Quaternion.identity);
            }
        }
        if (jf.time > 5000)
        {
            GameData.getInstance().main.gameWin();
            jf.enabled = false;
        }
    }
}
