using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resrart : MonoBehaviour
{
    public void Reset()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
