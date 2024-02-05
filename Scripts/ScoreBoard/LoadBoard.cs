using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoadBoard : MonoBehaviour
{
    public TMP_Text Top;
    private string[] names;
    private string[] scores;

    public void LoadClick()
    {
        names = Scoreboard.Instance.GetNicks();
        scores = Scoreboard.Instance.GetScores();
        Top.text = "";
        for (int i = 0; i < names.Length; i++)
        {
            Top.text += names[i] + " " + scores[i] + "\n";
        }
    }
}
