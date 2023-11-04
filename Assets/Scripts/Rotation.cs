using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(90, 100 * -1 * Time.time, 0);
    }
}
