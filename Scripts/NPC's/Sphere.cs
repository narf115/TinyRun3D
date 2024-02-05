using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField]
    float radius;
    Vector3 location;
  

    public Vector3 GetRandomPoint()
    {

        location = transform.position + Random.insideUnitSphere * radius;
        return new Vector3(location.x, 0.5f, location.z);
       

    }


}
