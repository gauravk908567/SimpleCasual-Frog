using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public float spawndelay = 0.85f;
    public GameObject carprefab;
    private float SpawnInterval;
    

  
    void Update()
    {
        if(SpawnInterval<=Time.time)
        {
            spawn();

            SpawnInterval = Time.time + spawndelay;

        }
    }

    void spawn()
    {
        Instantiate(carprefab, transform.position, transform.rotation);

    }

}
