using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    public Text counterText;
    public  FlowerSpawn  script;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCounterText();
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = "Count:" + script.getCount();
        //count++;
        //UpdateCounterText();
    }

    void UpdateCounterText()
    {
        counterText.text = "Count:" + script.CollectedTargets;
    }

}

