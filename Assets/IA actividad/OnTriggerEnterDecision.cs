using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class OnTriggerEnterDecision : AIDecision
{
    private bool hasPlayerEnter;
    

    public override void Initialization()
    {
        base.Initialization();
        hasPlayerEnter = false;
    }


    public override bool Decide()
    {
        return hasPlayerEnter;
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
