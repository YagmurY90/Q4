using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class charactercontrollerr : MonoBehaviour
{

    private Animator animator;
    private Rigidbody playerRb;
    public float jumpforce = 4f;
    public bool isOnGround = true;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("walk", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            animator.SetBool("jump", true);
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isOnGround = false;

            /*transform.Translate(new Vector3(0, 2f, 0) * Time.deltaTime);*/
        }
        else
        {
            animator.SetBool("jump", false);
            isOnGround = true;


        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("backwalk", true);
            transform.Translate(new Vector3(0, 0, -2f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("backwalk", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("walkleft", true);
            transform.Translate(new Vector3(-2f, 0, 0) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walkleft", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("walkright", true);
            transform.Translate(new Vector3(2f, 0, 0) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walkright", false);
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("run", true);
            transform.Translate(new Vector3(0, 0, 3f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("run", false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "nextT2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
