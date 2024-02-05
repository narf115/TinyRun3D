using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollower : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player,point;

    // Update is called once per frame
   
    void Update()
    {
        transform.LookAt(Player.transform);
         transform.position = Vector3.MoveTowards(point.position, Player.transform.position, 0.25f);
        
    }
    
}
