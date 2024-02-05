using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class NpcBehavior : MonoBehaviour
{
    MovementBehaviour mb;
    Vector3 _dir;
    bool exist;
    private PlayerController PC;
    int points = 0;
    public UnityEvent<int> UpdatePoints;
    private bool following = false;
    private Animator anim;
    private PlaySound AS;
    
    void Start()
    {
        mb = GetComponent<MovementBehaviour>();
        PC = GetComponent<PlayerController>();
        exist = false;
        anim = GetComponent<Animator>();
        AS = GetComponent<PlaySound>();
    }


    void FixedUpdate()
    {

        if (exist)
        {


            _dir = new Vector3(InputManager.ip.movevalue, 0 + (-10) * Time.deltaTime, 1);
            _dir.Normalize();

            mb.Move(_dir);
        }
    }
  
    private void OnTriggerEnter(Collider other)
    {
        if (!following)
        {
            AS.PlaySounds();
            anim.SetBool("Catch", true);
            
            transform.position = other.gameObject.GetComponentInChildren<Sphere>().GetRandomPoint(); 
            exist = true;
            points++;
            UpdatePoints.Invoke(points);
            GetComponent<BoxCollider>().isTrigger = false;
            GameManager.gm.UpdatePoints(2);

            int LayerFollowing = LayerMask.NameToLayer("Default");
            gameObject.layer = LayerFollowing;
            following = true;
        }
    }
    
}
