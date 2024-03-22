using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        animator.SetBool("Running", true);
        animator.SetBool("Jump", false);
        animator.SetBool("Crawl", false);

    }
    public void running()
    {
        animator.SetBool("Running", true);
        animator.SetBool("Jump", false);
        animator.SetBool("Crawl", false);
    }
    public void jump()
    {
        animator.SetBool("Jump", true);
    }
    public void slide()
    {
        animator.SetBool("Crawl", true);

    }
}
