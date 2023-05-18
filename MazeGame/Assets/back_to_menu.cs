using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_to_menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void backtomenu()
    {
       // button.enabled = true;
            Debug.Log("Clicked back");
            SceneManager.LoadScene("Scene01");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
    }

    
}
