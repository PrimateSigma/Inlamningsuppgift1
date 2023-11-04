using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Oscillation : MonoBehaviour
{
    // public float moveSpeed;
    // public Transform startPosition;
    // public Transform endPosition;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        // transform.position = startPosition.position;
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.Lerp(transform.position, endPosition.position, Time.deltaTime * moveSpeed);
        float offset = Mathf.Sin(Time.time * frequency);
        transform.position = initialPosition + Vector3.right * offset;
    }
}
