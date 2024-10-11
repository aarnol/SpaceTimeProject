using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public static int enemiesKilled = 0;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(enemiesKilled >10){
            SceneManager.LoadScene("Scenes/WinScene");
        }
        
    }
    
}
