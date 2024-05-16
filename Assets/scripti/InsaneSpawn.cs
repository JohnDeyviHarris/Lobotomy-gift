using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsaneSpawn : MonoBehaviour
{
    public GameObject insaneball;
    private int spawnornet;
    void Start()
    {
        spawnornet = Random.Range(0, 2500000);
    }

    void FixedUpdate()
    {
        if (spawnornet < 200) {
            Instantiate(insaneball, transform.position, transform.rotation);
        }
        spawnornet = Random.Range(0, 2500000);
    }
}
