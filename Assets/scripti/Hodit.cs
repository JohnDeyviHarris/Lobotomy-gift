using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Threading.Tasks;

public class Hodit : MonoBehaviour
{
    private KeyCode Left;
    private KeyCode Right;
    public float Speed;
    public TextMeshProUGUI texta;
    public TextMeshProUGUI textb;
    public TextMeshProUGUI textgo;
    public TextMeshProUGUI textgog;
    [SerializeField] private GameObject RestartBTN;
    [SerializeField] private AudioSource Defeat;
    private int ezcounter;
    private int insanecounter;
    public AudioSource audio;
    public AudioSource audio0;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    private bool win;
    void Start()
    {
        Left = KeyCode.A;
        Right = KeyCode.D;
        Speed = 0.05f;
        win = true;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(Left)) {
            transform.position += new Vector3(-Speed, 0, 0);
            transform.Rotate(new Vector3(0, -2, 0));
        }
        if (Input.GetKey(Right)) {
            transform.position += new Vector3(Speed, 0, 0);
            transform.Rotate(new Vector3(0, 2, 0));
        }
    }
     void OnCollisionEnter(Collision colls)
    {
        if (colls.gameObject.tag == "ez") {
            ezcounter += 1;
            texta.text = ezcounter.ToString();
            audio.Play();
            if (ezcounter > 99) {
                textgog.fontSize = 36;
                RestartBTN.SetActive(true);
                audio1.Play();
                Destroy(gameObject);
                Destroy(audio3);  
            } 
        }
        if (colls.gameObject.tag == "insane") {
            ezcounter -= 5;
            insanecounter += 1;
            texta.text = ezcounter.ToString();
            textb.text = insanecounter.ToString();
            if (ezcounter < 1) {
                Defeat.Play();
                textgo.fontSize = 36;
                RestartBTN.SetActive(true);
                Destroy(gameObject);
                win = false;
                Destroy(audio3);  
            }
            audio0.Play();
            Speed = 0.05f;
            
        }
        if (colls.gameObject.tag == "normal") {
            ezcounter += 15;
            texta.text = ezcounter.ToString();
            audio2.Play();
            if (ezcounter > 99) {
                textgog.fontSize = 36;
                audio1.Play();
                Destroy(gameObject);
                Destroy(audio3);  
            }
        }
    }
}