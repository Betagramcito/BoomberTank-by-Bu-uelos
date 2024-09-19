using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombas : MonoBehaviour
{
    public GameObject bombPrefab;
    public Transform bombSpawnPoint;
    public float bombCooldown = 2.0f;
    public float nextBombTime = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.time >= nextBombTime)
        {
            SpawnBomb();
            nextBombTime = Time.time + bombCooldown;
        }
    }
    void SpawnBomb()
    {
        Instantiate(bombPrefab, bombSpawnPoint.position, bombSpawnPoint.rotation);
    }
}
