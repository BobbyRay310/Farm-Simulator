using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update() //Follows the Target
    {
        
    }
    private void FixedUpdate() //Moves towards the target
    {
        
    }
    private void GetTarget()
    {

    }
}
