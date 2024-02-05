using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcsCheats : MonoBehaviour
{
    public GameObject NpcsPrefabs;
    public Transform SP;
  
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(NpcsPrefabs,new Vector3(SP.transform.position.x, SP.transform.position.y, SP.transform.position.z), SP.rotation);


        }
    }
}
