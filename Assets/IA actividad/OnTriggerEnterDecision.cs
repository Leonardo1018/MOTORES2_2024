using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class OnTriggerEnterDecision : AIDecision
{
    private bool hasPlayerEnter;
    private float timer = 0;

    public override bool Decide()
    {
        throw new System.NotImplementedException();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _brain.Target = other.transform;
            hasPlayerEnter = true;
        }
       

    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        hasPlayerEnter = false;
       
    }

}
