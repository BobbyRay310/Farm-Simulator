using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAZER_SHOOTER : MonoBehaviour
{
    public Transform lazerSpawnPoint;
    public GameObject lazerPrefab;
    public float lazerSpeed = 10;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.O))
        {
            var lazer = Instantiate(lazerPrefab, lazerSpawnPoint.position, lazerSpawnPoint.rotation);
            lazer.GetComponent<Rigidbody>().velocity = lazerSpawnPoint.forward * lazerSpeed;
        }
        
    }


}
