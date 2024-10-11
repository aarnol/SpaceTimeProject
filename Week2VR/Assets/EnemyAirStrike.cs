using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAirStrike : MonoBehaviour
{
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
            if(collision.gameObject.layer == 8){
                Destroy(collision.gameObject);
                

            }
                
                Destroy(gameObject);
        
        
    }
}
