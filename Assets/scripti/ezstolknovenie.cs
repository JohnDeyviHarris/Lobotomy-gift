using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ezstolknovenie : MonoBehaviour
{
    public GameObject me;

    void Start()
    {
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collisions)
    {
        if (collisions.gameObject.tag == "Player") {
            Destroy(gameObject);
            print("Player");
            
        }
        if (collisions.gameObject.tag == "Ground") {
            Destroy(gameObject);
            print("Ground");
        }
    }
}
