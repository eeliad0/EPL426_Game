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
        script = FindObjectOfType<FlowerSpawn>();
        UpdateCounterText(script);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateCounterText(FlowerSpawn sc)
    {
        counterText.text = "Count:" + sc.CollectedTargets.ToString();
    }

}

