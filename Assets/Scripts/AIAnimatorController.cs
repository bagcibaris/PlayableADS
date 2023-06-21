using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]

public class AIAnimatorController : MonoBehaviour
{
    private Animator AIanimator;

    private void Awake()
    {
        AIanimator = GetComponent<Animator>();    
    }


    public void PlayAIRun()
    {
        AIanimator.Play("AIRun");
    }

}