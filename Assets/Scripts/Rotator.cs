using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name.Equals("Boy"))
        {
            other.gameObject.transform.position = new Vector3 (0f, 0f, -6.6f);
        }    
        else if(other.gameObject.name.Equals("AIGirl"))
        {
            other.gameObject.transform.position = new Vector3 (0f, 0f, -6.6f);
        } 
    } 

    void Update()
    {
        
    }
}
