using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTrayector : MonoBehaviour
{
    public List<GameObject> Path ;
  
    private int index;
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
        dir = Path[index].transform.position - transform.position;
        dir.Normalize();
        if (Vector3.Distance(transform.position, Path[index].transform.position) > 0.1)
        {
            mb.MoveToTarget(dir);
        }
        else
        { 
            if(index==0)
            {
                index = 1;
            }
            else
            {
                index = 0;
            }
        }
      
    }
}
