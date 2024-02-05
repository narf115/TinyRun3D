using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PointsCanvas : MonoBehaviour
{
    private int Points;
    private void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "0";
        Points = 0;
    }

    public void UpdateScore(int p)
    {
        if (Points >= 0)
        {
            Points += p;
            GetComponent<TextMeshProUGUI>().text = "" + Points;

        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = "0";
        }
    }
}
