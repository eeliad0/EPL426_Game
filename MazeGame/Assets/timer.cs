using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class timer : MonoBehaviour
{

    public Text timerText;
    private float starTime;

    // Start is called before the first frame update
    void Start()
    {
        starTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - starTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        Debug.Log(seconds);

        timerText.text=minutes+":"+seconds;

    }
}
