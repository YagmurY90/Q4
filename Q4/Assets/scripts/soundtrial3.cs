using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtrial3 : MonoBehaviour
{
    public AudioSource src;
    public AudioClip fs, es;

    private void Start()
    {
        src.clip = es;
        src.Play();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            src.clip = fs;
            src.Play();

        }
        else
        {
            src.enabled = false;

        }
    }
}
