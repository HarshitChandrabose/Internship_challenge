using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawn : MonoBehaviour
{
    public float spawnRate = .25f;

    public GameObject TREEPrefab;

    private float nextTimeToSpawn = 1f;

    // Update is called once per frame
    void Update()
    {
        spawnRate = Random.Range(0.3f, .9f);
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(TREEPrefab, new Vector2(12,1), Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }


}
