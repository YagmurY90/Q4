using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class jumpscaree : MonoBehaviour
{
    public GameObject JumpScareImg;
    public AudioSource audioSource;
    private bool isPlayed=false;
   
    void Start()
    {
       JumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player") 
        {
            if (!isPlayed)
            {
                JumpScareImg.SetActive(true);
                audioSource.Play();
                StartCoroutine(DisableImg());
                isPlayed = true;
            }
           
        }
    }

    IEnumerator DisableImg()
    {
        yield return new WaitForSeconds(1);
        JumpScareImg.SetActive(false);
    }
}
