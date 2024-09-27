using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    private int IswalkingMash;
    private int IsrunningMash;

    void Start()
    {
        animator = this.GetComponent<Animator>();
        IswalkingMash = Animator.StringToHash("Iswalking");
        IsrunningMash = Animator.StringToHash("Isrunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool Iswalking = animator.GetBool(IswalkingMash);
        bool forwardPressed = Input.GetKey(KeyCode.W);

        bool Isrunning = animator.GetBool(IsrunningMash);
        bool Runpressed = Input.GetKey(KeyCode.LeftShift);


        if (forwardPressed && !Iswalking)
        {
            animator.SetBool("IswalkingMash", true);
        }

        if (!forwardPressed && Iswalking)
        {
            animator.SetBool("IswalkingMash", false);
        }

        if ((forwardPressed && Runpressed) && !Isrunning)
        {
            animator.SetBool("IsrunningMash", true);
        }

        if ((!forwardPressed || !Runpressed) && Isrunning)
        {
            animator.SetBool("IsrunningMash", false);
        }
    }
}