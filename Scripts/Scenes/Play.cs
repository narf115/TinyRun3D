using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
    public GameObject tuto;
   public void PlayOn()
    {
        PlayTutorial();


    }
   

    public void PlayOn3()
    {
    SceneManager.LoadScene("3");
    }
    public void PlayTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Play1()
    {
        SceneManager.LoadScene("1");
    }
}
