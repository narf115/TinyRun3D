using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    private Transform Path;
  
    private MovementBehaviour mb;
   

    // Start is called before the first frame update
    void Start()
    {

        mb = GetComponent<MovementBehaviour>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir;
       // dir = Path;
        dir = new Vector3 (1,-1,0);       
        
        mb.Move(dir);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}