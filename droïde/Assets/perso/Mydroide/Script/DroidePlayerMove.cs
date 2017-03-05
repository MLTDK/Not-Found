using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidePlayerMove : MonoBehaviour
{

    private Animator anim;
    private float vert;
    private float hor;
    private float hor2;
    private float hor3;
    private float hor4;
    private float hor5;

    private float jump;

    void Start()
    {
        anim = GetComponent<Animator>();

    }
    void Update()
    {
        vert = Input.GetAxis("Vertical");
        anim.SetFloat("walk", vert);
        
        hor = Input.GetAxis("Horizontal");
        anim.SetFloat("walkD", hor);

        hor2 = Input.GetAxis("Horizontal2");
        anim.SetFloat("walkL", hor2);

        hor3 = Input.GetAxis("Horizontal3");
        anim.SetFloat("run", hor3);

        hor4 = Input.GetAxis("Horizontal4");
        anim.SetFloat("runD", hor4);

        hor5 = Input.GetAxis("Horizontal5");
        anim.SetFloat("runL", hor5);

        jump = Input.GetAxis("Jump");
        anim.SetFloat("jump",jump);
        
      
    }
}
