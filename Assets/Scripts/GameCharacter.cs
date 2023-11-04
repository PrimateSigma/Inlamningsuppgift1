using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCharacter : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null; // Probably isn't needed.
    [SerializeField] private LayerMask playerMask;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidBodyComponent;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
        jumpKeyWasPressed = true;

        }

        horizontalInput = Input.GetAxis("Horizontal");
    }


    void FixedUpdate() 
    {
        rigidBodyComponent.velocity = new Vector3(horizontalInput * 2,rigidBodyComponent.velocity.y, 0);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0) 
        {
            return;
        }

        if(jumpKeyWasPressed)
        {
            rigidBodyComponent.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
            jumpKeyWasPressed = false; //Makes it run only once.
        }


    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.layer == 8) 
        {
            Destroy(other.gameObject);
        }
    }

    
}
