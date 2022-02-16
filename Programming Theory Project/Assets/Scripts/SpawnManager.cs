using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] projectilePrefabs;
    private float startDelay = 2;
    private float spawnInterval = 4.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomProjectile", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomProjectile()
    {
        int projectileIndex = Random.Range(0, projectilePrefabs.Length);
        Vector3 spawnPos = new Vector3(21, 1, 0);

        Instantiate(projectilePrefabs[projectileIndex], spawnPos, projectilePrefabs[projectileIndex].transform.rotation);
    }

}
