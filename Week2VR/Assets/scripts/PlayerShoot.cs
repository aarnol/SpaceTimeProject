using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletPrefab;
    [SerializeField]
    private float shootPower = 2000f;
    public InputActionReference trigger;
    // Start is called before the first frame update
    void Start()
    {
        trigger.action.performed += Shoot;
    }
    void Shoot(InputAction.CallbackContext _)
    {
        GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward *shootPower);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
