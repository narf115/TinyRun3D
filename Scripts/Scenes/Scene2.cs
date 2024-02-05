using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene2 : MonoBehaviour
{
   
    public GameObject gb;
    private void OnTriggerEnter(Collider other)
    {
         gb.SetActive(true);
       
    
        Invoke("Level", 3);
    }
    void Level()
    {
        SceneManager.LoadScene("2");
        Debug.Log("xde");
    }
}
