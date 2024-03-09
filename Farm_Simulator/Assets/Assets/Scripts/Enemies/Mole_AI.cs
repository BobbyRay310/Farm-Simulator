using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole_AI : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    private Transform player;

    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player").transform;   
    }

    void Update()
    {
        float distanceFromPlayer = Vector3.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }


}
