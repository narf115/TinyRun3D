using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreCanvas : MonoBehaviour
{
    private int Scoree;
    private void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "0/5";
        Scoree = 0;
    }
 
    public void UpdateScore(int score)
    {
        if (Scoree >= 0)
        {
            Scoree += score;
            GetComponent<TextMeshProUGUI>().text = "" + Scoree + "/5";
           
        }
        else 
        {
            GetComponent<TextMeshProUGUI>().text = "0" ;
        }
    }
   
}
