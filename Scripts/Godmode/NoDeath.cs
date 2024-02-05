using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDeath : MonoBehaviour
{
    public GameObject Player,God;
    private bool IsActived = false;

    void Start()
    {
        
    }

  
    void Update()
    {
        NoDeaths();
    }
    public void NoDeaths()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (IsActived == false)
            {
                Player.GetComponent<HealthBehavior>().SetHealth(1000000);
                Player.GetComponent<PlayerController>().ChangeGod('2');

                IsActived = true;
                God.SetActive(true);
            }
            else
            {
                IsActived = false;
                God.SetActive(false);
                Player.GetComponent<HealthBehavior>().SetHealth(1);
          
            }
        }
    }
}
