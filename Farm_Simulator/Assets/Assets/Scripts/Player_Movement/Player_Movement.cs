using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Movement : MonoBehaviour
{
    Rigidbody rigidBody;
    public float speed = 4;
    public Weapon weapon;

    [SerializeField] private AudioSource walkingSoundEffect;
    [SerializeField] private AudioSource shotGunSFX;


    void Start() //To use the Rigidbody of the game object named Player
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update() //When the player left clicks, it registers to shoot the bullet prefab
    {
        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
            shotGunSFX.Play();
        }

        if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.D)))
        {
            walkingSoundEffect.Play();
        }
    }

 
    void FixedUpdate() //This is to have the player move when an input is made
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        rigidBody.AddForce(movement * speed/Time.deltaTime);
    }
}
