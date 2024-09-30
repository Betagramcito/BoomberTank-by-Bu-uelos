using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombas : MonoBehaviour
{
    public GameObject bombPrefab; 
    public Transform bombSpawnPoint;
    public float bombCooldown = 2.0f; 

    private float nextBombTime = 0f;

    public KeyCode teclaLanzar = KeyCode.E; 

    void Update()
    {
        if (Input.GetKeyDown(teclaLanzar) && Time.time >= nextBombTime)
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
