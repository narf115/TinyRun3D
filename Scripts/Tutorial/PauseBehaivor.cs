using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBehaivor : MonoBehaviour
{
    public GameObject gs,gs2;
    private void Start()
    {
        Invoke("Stop", 0f);
            
    }
    public void Stop()
    {
        Time.timeScale = 0f;
        gs.SetActive(true);
    }
    public void Start(GameObject gb)
    {
        if(InputManager.ip.select == 1)
        {
            Time.timeScale = 1f;
            gb.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            gb.SetActive(false);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        gs.SetActive(true);
    }
}
