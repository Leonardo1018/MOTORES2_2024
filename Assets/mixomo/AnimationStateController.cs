using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;



public class AnimationStateController : MonoBehaviour
{
    private Animator animator;
    private float velocity;
    private int velocityHash;
    public float acceleration= 1.0f;
    public float deceleration = 1.0f;
    void Start()
    {
        animator = GetComponent<Animator>();
        velocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey(KeyCode.LeftShift);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        if (forwardPressed)
        {
            velocity += Time.deltaTime * acceleration;
        }

        if (!forwardPressed)
        {
            velocity -= Time.deltaTime * deceleration;
        }

        animator.SetFloat(velocityHash, velocity); 
    }
}
