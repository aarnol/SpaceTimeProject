using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0f,3f);
        float y = Random.Range(0f,3f);
        float z = Random.Range(0f,3f);
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x,y,z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
