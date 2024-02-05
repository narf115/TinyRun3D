using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private string[] nicks;
    private string[] scores;

    private static Scoreboard _instance = null;
    public static Scoreboard Instance => _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }
    }
    public void SetLoad(string[] ns, string[] sc)
    {
        nicks = ns;
        scores = sc;
    }

    public string[] GetNicks()
    {
        return nicks;
    }

    public string[] GetScores()
    {
        return scores;
    }
}
