using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIController : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    [SerializeField] private AIAnimatorController _AIanimatorController;
    public NavMeshAgent agent;

    private void Start()
    {
      _AIanimatorController.PlayAIRun();   
    }
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.destination = movePositionTransform.position;
    }
}
