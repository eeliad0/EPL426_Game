using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class timer : MonoBehaviour
{

    public Text timerText;
    private float starTime;
    public string seconds;
    public string minutes;

    // Start is called before the first frame update
    void Start()
    {
        starTime = Time.time;
    
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - starTime;
        minutes = ((int)t / 60).ToString();
        seconds = (t % 60).ToString("f0");

        //Debug.Log(seconds);

        timerText.text = minutes+":"+seconds;

    }

    public string stop(){
        return minutes+":"+seconds;
        
    }
}
