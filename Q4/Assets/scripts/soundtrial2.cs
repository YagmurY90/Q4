using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtrial2 : MonoBehaviour
{
    public AudioSource src;
    public AudioClip fs, es,rs;

    private void Start()
    {
        src.clip = es;
        src.Play();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
               src.clip = rs;
                src.Play();

            }
            else
            {
                src.clip = fs;
                src.Play();
            }
        }
        else
        {
            src = null;

        }
    }
}
