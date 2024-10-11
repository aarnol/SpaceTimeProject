using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class teleport : MonoBehaviour
{
    [SerializeField]
    private LayerMask castLayer;
    [SerializeField]
    private GameObject playerOrigin;
    [SerializeField]
    private InputActionReference teleportTrigger;
    [SerializeField]
    private InputActionReference fireballButton;
    [SerializeField]
    private GameObject flamePillar;

    [SerializeField]
    AudioClip clip;

    void Start(){
        
        teleportTrigger.action.performed += DoRaycast;
        fireballButton.action.performed += DoFireBall;
    }

    void DoRaycast(InputAction.CallbackContext _) {
        // The Unity raycast hit object, which will store the output of our raycast
        Debug.Log("Button pressed");
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, castLayer)) {
            // The object we hit will be in the collider property of our hit object.
            // We can get the name of that object by accessing it's Game Object then the name property
            
            
            // Don't forget to attach the player origin in the editor!
            playerOrigin.transform.position = hit.collider.gameObject.transform.position;
        }
    }
    void DoFireBall(InputAction.CallbackContext _){
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, castLayer)) {
            Vector3 pos = new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y + 20f, hit.collider.transform.position.z);
            Debug.Log(pos.ToString());
            GameObject fire = Instantiate(flamePillar, pos , transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(clip);
        }

    }
}
