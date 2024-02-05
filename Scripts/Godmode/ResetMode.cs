using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetMode : MonoBehaviour
{
    public string level;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(level);
        }
        if(InputManager.ip.select==1)
        {
            SceneManager.LoadScene(level);
        }
    }
}
