using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdatePoints : MonoBehaviour
{
    public TMP_Text tx;
    GameObject gb;
    void Start()
    {
        
        GetComponent<TextMeshProUGUI>().text = "" + GameManager.gm.ReturnPoints();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
