using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    private MovementBehaviour mv;
    private Vector3 _dir;
    private HealthBehavior HB;
    public bool IsGod = false;
   

    void Start()
    {
        anim = GetComponent<Animator>();
        mv = GetComponent<MovementBehaviour>();
         
        HB = GetComponent<HealthBehavior>();
      
    }
    private void FixedUpdate()
    {
       
         _dir = new Vector3(InputManager.ip.movevalue, 0, 1);
        _dir.Normalize();
        mv.Move(_dir);

    }
   
   
  public void ChangeGod(int a)
    {
        if (a == '2')
        {
            IsGod = true;
            
        }
        else
            IsGod = false;
    }
   
    public void Stop()
    {
        mv.SetSpeed(0);
    }
}
