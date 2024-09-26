using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float distance;
    public GameObject head;

    [SerializeField]
    public GameObject regEnemy;
    public GameObject shootEnemy;
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
            Vector3 direction = new Vector3(Random.Range(0f, 10f), 0, Random.Range(0f, 10f)).normalized;
            Vector3 pos = direction * distance + head.transform.position;
            if(Random.Range(0f,10f) < 5){
                GameObject enemy = Instantiate(regEnemy, pos, new Quaternion(0, 0, 0, 0));
            }
            else{
                GameObject shooter = Instantiate(shootEnemy, pos, new Quaternion(0, 0, 0, 0));
            }
            
            time = Time.time;
        }
       

    }
    
}
