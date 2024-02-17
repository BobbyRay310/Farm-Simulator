using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject enemyPrefab;

    [SerializeField]
    private float enemyInterval = 3.5f;


    void Start()
    {
        StartCoroutine(spawn(enemyInterval, enemyPrefab));

    }

    private IEnumerator spawn(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
       GameObject newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
        StartCoroutine(spawn(interval, enemy));
    }
   
}
