using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{

    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 10;
    [SerializeField] private float _turnspeed = 360;
    private Vector3 _input;

    
    private float horizontal;
    private float vertical;
    private bool flipped;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        flipped = false;
    }
    //We originally had the camera facing Orthographic similarly to the Unity Tank Camera,We don't plan on using this script
    void Update()
    {
        GatherInput(); //A method that's below
        Look(); //A method that's below

    }

    void FixedUpdate()
    {
        Move(); //A method below
        _rb.velocity = new Vector3(horizontal, vertical * _speed, _rb.velocity.z);
        _rb.velocity = new Vector3(vertical, horizontal * _speed, _rb.velocity.x);


    }
    void GatherInput() //This is used to take input at Look() method. Having the player move horizontal or vertically
    {
       horizontal = Input.GetAxisRaw("Horizontal");
       vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.D))
        {
            _rb.velocity = new Vector3(horizontal * _speed, _rb.velocity.z);

            if (flipped == false)
            {
                transform.Rotate(0, 90, 0);
                flipped = true;
              //  _rb.AddForce(_input * _speed / Time.deltaTime);

            }
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            _rb.velocity = new Vector3(horizontal * _speed, _rb.velocity.z);

            if (flipped == true)
            {
                transform.Rotate(0, 90, 0);
                flipped = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            _rb.velocity = new Vector3(vertical * _speed, _rb.velocity.y);

            if (flipped == false)
            {
                transform.Rotate(0, 90, 0);
                flipped = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {

            if (flipped == true)
            {
                transform.Rotate(0, 90, 0);
                flipped = false;
            }
        }


        //    _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }
    void Look() //A player movement to have it accurately go forward with the camera instead of it going diagonally
    {
        if (_input != Vector3.zero)
        {
            var matrix = Matrix4x4.Rotate(Quaternion.Euler(0, 0, 0));

            var skewedInput = matrix.MultiplyPoint3x4(_input);

            var relative = (transform.position + skewedInput) - transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnspeed * Time.deltaTime);
        }
    }

    void Move() //This changes the position of the player position depending on the input
    {
        //_rb.MovePosition(transform.position + (transform.forward * _input.magnitude) * _speed * Time.deltaTime);
        _rb.velocity = new Vector3(vertical, horizontal * _speed, _rb.velocity.x);
        _rb.velocity = new Vector3(vertical, horizontal * _speed, _rb.velocity.z);


    }
}

