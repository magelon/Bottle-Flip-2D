using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderBar : MonoBehaviour
{
    public GameObject gm;
    JumpFlip jf;
    public Slider sl;
    [SerializeField]
    private float slValue;

    void Start()
    {
        jf = gm.GetComponent<JumpFlip>();
    }
    
    void Update()
    {
        slValue = jf.time;
        sl.value = jf.time;


    }
}
