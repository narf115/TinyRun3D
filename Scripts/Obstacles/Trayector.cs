using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trayector : MonoBehaviour
{
    public GameObject Path;
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
        dir = Path.transform.position - transform.position;
        dir.Normalize();
        if (Vector3.Distance(transform.position, Path.transform.position) >= 0.1)
        {
            mb.MoveToTarget(dir);
            
        }
        else
        {
            mb.SetSpeed(0);
        }
           

    }
}
