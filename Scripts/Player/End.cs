using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class End : MonoBehaviour
{
     GameObject gb;
  
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.gm.ReturnFollowers() >= 5)
        {
            other.gameObject.GetComponent<Anim>().Ball();
        }
        else
        {

           
            other.gameObject.GetComponent<MovementBehaviour>().SetSpeed(0);
           // other.gameObject.GetComponent<Anim>().Fail();
            gb.SetActive(true);
        }
    }
}
