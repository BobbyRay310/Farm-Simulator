using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Movement : MonoBehaviour
{
    Rigidbody rigidBody;
    public float speed = 4;
    public Weapon weapon;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>(); 
    }

     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        rigidBody.AddForce(movement * speed/Time.deltaTime);

    }
}
