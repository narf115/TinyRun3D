using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void Removed(GameObject gb)
    {
        Destroy(gb);
    }
}
