using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMod : MonoBehaviour
{
    public Light lg;
    public float v1, v2,Timer,Timer2;
    public bool Lightt = true;
  
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Intensity", Timer,Timer2 );
    }
    public void Intensity()
    {
        if (!Lightt)
        {
            lg.intensity = v1;
            
            Lightt = true;
        }
        else
        {
            
            lg.intensity = v2;
            Lightt = false;

        }
    }
}
