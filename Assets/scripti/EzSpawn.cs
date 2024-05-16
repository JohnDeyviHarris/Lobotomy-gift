using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EzSpawn : MonoBehaviour
{
    public GameObject ezball;
    private int spawnornet;
    void Start()
    {
        spawnornet = Random.Range(0, 500000);
    }

    void FixedUpdate()
    {
        if (spawnornet < 200) {
            Instantiate(ezball, transform.position, transform.rotation);
        }
        spawnornet = Random.Range(0, 500000);
    }
}
