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
            GameObject bullet = Instantiate(lazerPrefab, lazerSpawnPoint.position, lazerSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(lazerSpawnPoint.forward * lazerSpeed, ForceMode.Impulse);
        }

    }


}
