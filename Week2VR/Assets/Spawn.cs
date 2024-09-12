using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float distance;
    public GameObject head;
    public GameObject theCube;
    private float spawnRate = 1f;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > time + spawnRate)
        {
            Vector3 direction = new Vector3(Random.Range(0f, 10f), Random.Range(0f, 10f), Random.Range(0f, 10f)).normalized;
            Vector3 pos = direction * distance + head.transform.position;
            GameObject cube = Instantiate(theCube, pos, new Quaternion(0, 0, 0, 0));
            time = Time.time;
        }
       

    }
    
}
