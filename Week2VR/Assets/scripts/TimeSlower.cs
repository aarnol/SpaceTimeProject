using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlower : MonoBehaviour
{
    [SerializeField]
    private float time_scaler = 0.5f;
    [SerializeField]
    public GameObject rightHand;
    [SerializeField]
    public GameObject leftHand;

    private Vector3 rightPos;
    private Vector3 leftPos;
    // Start is called before the first frame update
    void Start()
    {
        rightPos = rightHand.transform.position;
        leftPos = leftHand.transform.position;
}

    // Update is called once per frame
    void Update()
    {
        float velocity = ((rightHand.transform.position - rightPos).magnitude + (leftHand.transform.position - leftPos).magnitude)/2/Time.deltaTime;
        rightPos = rightHand.transform.position;
        leftPos = leftHand.transform.position;
        Time.timeScale = velocity + 0.01f * time_scaler;
    }
}
