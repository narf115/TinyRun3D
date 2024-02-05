using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movee : MonoBehaviour
{
   [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
        public void  Move()
        {
        
            
            transform.position += transform.forward * Time.deltaTime * speed;
        
        }
    public void Move(Vector3 dir)
    {
        transform.position += dir* Time.deltaTime * speed;
    }
}

