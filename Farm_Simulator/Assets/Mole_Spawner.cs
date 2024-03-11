using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mole_Spawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject enemyPrefab;
    [SerializeField]
    private GameObject bigEnemyPrefab;

    [SerializeField]
    private float enemyInterval = 3.5f;
    [SerializeField]
    private float bigEnemyInterval = 10f;

    void Start()
    {
        StartCoroutine(spawn(enemyInterval, enemyPrefab));
        StartCoroutine(spawn(bigEnemyInterval, bigEnemyPrefab));

    }

    private IEnumerator spawn(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
       GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-10f, 10), Random.Range(-10, 10f),0), Quaternion.identity);
        StartCoroutine(spawn(interval, enemy));
    }
   
}
