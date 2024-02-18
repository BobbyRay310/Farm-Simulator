using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fly_AI : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 3f;

    public GameObject player;
    public float speed;

    public float turnSpeed = 5.0f;
    private float distance;

    public Vector3 _dir;
    public Transform target;
    private void Update() //This makes the enemy to follow the Player based on it's tag.
    {
        distance = Vector3.Distance(transform.position, player.transform.position); //Uses the Enemies positions
        Vector3 direction = player.transform.position - transform.position; //Locates the Player
        direction.Normalize();

        if (target)
        {
            _dir = target.position - GetComponent<Rigidbody>().position;
            _dir.Normalize();
            // Debug.Log(_dir);
        }

        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime); //Changes it's position towards The Player

//        Vector3 toTarget = player.transform.position - transform.position;
        //float angleToTarget = Vector3.Angle(transform.forward, toTarget);
     //   transform.RotateAround(this.transform.position, Time.deltaTime * turnRate * angleToTarget);
        //transform.Translate(toTarget * speed * Time.deltaTime);


    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(_dir * speed);
        transform.rotation = Quaternion.Euler(0, 90, 0);

        if (target)
        {
            Vector3 direction = target.position - transform.position;
            float angle = Mathf.Atan(direction.x) * Mathf.Rad2Deg;
            //   MoveDirection = direction * angle;
        }

    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
