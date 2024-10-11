using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletPrefab;
    [SerializeField]
    private float shootPower = 2000f;
    public InputActionReference trigger;
    [SerializeField]
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        trigger.action.performed += Shoot;
    }
    void Shoot(InputAction.CallbackContext _)
    {
        GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward *shootPower);
        GetComponent<AudioSource>().PlayOneShot(clip);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
