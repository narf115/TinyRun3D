using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShoot : MonoBehaviour
{
    public GameObject  Prefab;
    public Transform Point,Point2 ;
 

    void Start()
    {
        InvokeRepeating("Shoot", 2, 5);
    }
    public void Shoot()
    {
        Vector3 relativePos = Point2.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        Instantiate(Prefab, new Vector3(Point.transform.position.x, Point.transform.position.y, Point.transform.position.z), rotation);
    }
   
}
