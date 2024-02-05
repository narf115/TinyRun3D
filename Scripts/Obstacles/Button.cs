using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button : MonoBehaviour
{
    int a;
    public GameObject Wall;
   
    private void OnTriggerEnter(Collider other)
    {
     
        a =  Random.Range(0,4);
        Debug.Log(a);
        switch(a)
        {
            case 0:
                Wall.SetActive(true);
                break;
            case 1:
                Wall.SetActive(true);
                break;
            case 2:
                Wall.SetActive(true);
                break;
            case 3:
                Debug.Log("3");
                break;
            case 4:
                Debug.Log("4");
                break;
        }
    }
}
