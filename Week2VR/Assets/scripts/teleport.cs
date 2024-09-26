using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class teleport : MonoBehaviour
{
    [SerializeField]
    private LayerMask castLayer;
    [SerializeField]
    private GameObject playerOrigin;
    [SerializeField]
    private InputActionReference teleportTrigger;

    void Start(){
        
        teleportTrigger.action.performed += DoRaycast;
    }

    void DoRaycast(InputAction.CallbackContext _) {
        // The Unity raycast hit object, which will store the output of our raycast
        
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
}
