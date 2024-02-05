using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevelCheats : MonoBehaviour
{
   
    void Update()
    {
        Level1();
        Level2();
        Level3();
        LevelTuto();
    }
    public void Level1()
    {
            if(Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("1");
        }
    }
    public void Level2()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene("2");
        }
    }
    public void Level3()
    {
        if (Input.GetKeyDown(KeyCode.F3))
        {
            SceneManager.LoadScene("3");
        }
    }
    public void LevelTuto()
    {
        if (Input.GetKeyDown(KeyCode.F4))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}
