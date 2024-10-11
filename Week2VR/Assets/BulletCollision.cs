using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletCollision : MonoBehaviour
{
    public static int enemiesKilled;
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BulletCollision.enemiesKilled >2){
            SceneManager.LoadScene("Scenes/WinScene");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
            Destroy(collision.gameObject);
            Destroy(gameObject);
            BulletCollision.enemiesKilled +=1;
            
        
        
    }
}
