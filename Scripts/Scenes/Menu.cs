using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void MenuOn()
    {
        SceneManager.LoadScene("Menu");
    }
    public void END()
    {
        SceneManager.LoadScene("END");
    }
}
