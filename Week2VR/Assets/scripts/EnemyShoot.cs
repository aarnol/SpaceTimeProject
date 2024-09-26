using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    private float curr_time = 0f;
    private float shoot_time = 5f;
    private GameObject playerTarget;
    public float shootPower = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(playerTarget!=null){
            
            transform.LookAt(playerTarget.transform.position);
            
        }
        if(Time.time > shoot_time + curr_time){
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.transform.LookAt(playerTarget.transform.position);
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward *shootPower);
            curr_time = Time.time;
        }
        
    }
    private void OnTriggerEnter(Collider other){
        playerTarget = other.gameObject;

    }
}
