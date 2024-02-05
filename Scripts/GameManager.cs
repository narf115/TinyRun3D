using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    [SerializeField]
    public int minFollowers;
    public int Followers;
    [SerializeField]
    public int Points;

    private void Awake()
    {
        Followers = 0;
        if (gm == null)
        {
            gm = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (gm != this)
            {
                Destroy(gameObject);
            }
        }
        }
   
    public int ReturnFollowers()
    {
        return Followers;
    }
    public void UpdateFollowers(int a)
    {
        Followers += a;
    }
    public int ReturnPoints()
    {
        return Points;
    }
    public void UpdatePoints(int a)
    {
        Points += a;
    }
    
}
