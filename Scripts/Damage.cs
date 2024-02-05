using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private HealthBehavior hb;
    public int dmg;

    void Start()
    {
        hb = GetComponent<HealthBehavior>();


    }
   
    private void OnTriggerEnter(Collider other)
    {
       // hb.Hurt(1);
       
        other.gameObject.GetComponent<HealthBehavior>().Hurt(dmg);
       
        // Debug.Log("PowerUp");
        // PowerUp.Invoke();


    }
}
