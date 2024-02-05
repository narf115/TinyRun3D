using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Die : MonoBehaviour
{
    public GameObject sb;
    void Level()
    {
        sb.SetActive(true);
    }
    public void NoWin()
    {
        Invoke("Level", 1.5f);
    }
}
