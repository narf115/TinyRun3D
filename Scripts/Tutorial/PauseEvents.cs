using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseEvents : MonoBehaviour
{
    public GameObject gs;
    public void Starte(GameObject gb)
    {
        Time.timeScale = 1f;
        gb.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        gs.SetActive(true);
    }
}
