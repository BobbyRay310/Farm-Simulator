using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pellet : MonoBehaviour
{
    private Vector3 shootDir;

    public void Setup(Vector3 shootDir) //Changes prefab position when bullet is shot out
    {
        this.shootDir = shootDir;
    }
    private void Update() //This adds speed to the bullet
    {
        float moveSpeed = 20f;
        transform.position += shootDir * moveSpeed * Time.deltaTime;

    }

}
