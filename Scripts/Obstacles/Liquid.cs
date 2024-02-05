using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liquid : MonoBehaviour
{
    public int speed;
    private void OnTriggerEnter(Collider other)
    {
        
        other.gameObject.GetComponent<MovementBehaviour>().SetSpeed(speed);
    }
}
