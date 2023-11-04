using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject respawnPoint;
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            other.gameObject.transform.position = respawnPoint.transform.position;
        }
    }
}
