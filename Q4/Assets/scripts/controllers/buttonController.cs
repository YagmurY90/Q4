using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{
    public GameObject gameObject;
    bool active;
    public string scenename;
    public void OpenAndClose()
    {
        if (active == false)
        {
            gameObject.transform.gameObject.SetActive(true);
            active = true;
        }
        else
        {
            gameObject.transform.gameObject.SetActive(false);
            active = false;

        }

      
    }

    public void Changescene1()
    {
        SceneManager.LoadScene("Akapisi");
    }

    public void Changescene2()
    {
        SceneManager.LoadScene("Bkapisi");
    }
    public void Changescene3()
    {
        SceneManager.LoadScene("Ckapisi-R2");
    }
    public void Changescene4()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Changescene5()
    {
        SceneManager.LoadScene("R1");
    }
    public void Changescene6()
    {
        SceneManager.LoadScene("R2cevFas-R3");
    }
   
    public void Changescener4()
    {
        SceneManager.LoadScene("R4");
    }

    

}
