using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalSpawn : MonoBehaviour
{
    public GameObject normalball;
    private int spawnornet;
    void Start()
    {
        spawnornet = Random.Range(0, 4000000);
    }

    void FixedUpdate()
    {
        if (spawnornet < 200) {
            Instantiate(normalball, transform.position, transform.rotation);
        }
        spawnornet = Random.Range(0, 4000000);
    }
}
