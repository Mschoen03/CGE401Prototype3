using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Matthew Schoen
 * Prototype 3
 * Spawns the barricade obstacle
 * 
 */


public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
