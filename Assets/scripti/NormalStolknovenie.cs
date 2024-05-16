using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalStolknovenie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
