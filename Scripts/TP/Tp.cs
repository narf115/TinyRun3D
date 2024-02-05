using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    public Transform point;
    private GameObject bs;
    public PlaySound As;
    public GameObject fX;
    private void Start()
    {
        As = GetComponent<PlaySound>();
    }
    private void OnTriggerEnter(Collider other)
    {
        bs = other.gameObject;
        Tele();
        fX.SetActive(true);
        As.PlaySounds();
        Invoke("OutTp", 5);
        
    }

    public void Tele()
    {
        bs.transform.position = new Vector3(point.transform.position.x, point.transform.position.y, point.transform.position.z);
    }
    public void OutTp()
    {
        fX.SetActive(false);
    }
}
