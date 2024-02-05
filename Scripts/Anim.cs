using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Ball()
    {
        anim.SetBool("Win", true);
    }
    public void ChangeAnim()
    {
        anim.SetBool("Live", false);
    }
    public void Fail()
    {
        anim.SetBool("F", false);
    }
}
