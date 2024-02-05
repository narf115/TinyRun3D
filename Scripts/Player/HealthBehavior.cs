using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    private int maxhealth;
    public int health;
    


    public UnityEvent Die;
    void Start()
    {
        // health = maxhealth; 
        health = 1;
    }

    public void Hurt(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Die.Invoke();
        }
    }

    public void SetHealth(int newhealth)
    {
        if (newhealth<=maxhealth)
        health = newhealth;
    }
    public int GetHealth()
    {
        return health;

    }
}
