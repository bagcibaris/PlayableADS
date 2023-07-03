using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickForce : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.name.Equals("Boy"))
        {
            // other.gameObject.GetComponent<Rigidbody>().AddForce(-other.gameObject.GetComponent<Rigidbody>().velocity.normalized * 50,ForceMode.Impulse);
            other.gameObject.GetComponent<Rigidbody>().AddForce(-other.contacts[0].normal * 900,ForceMode.Impulse);
        }    
        else if(other.gameObject.name.Equals("AIGirl"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(-other.contacts[0].normal * 20,ForceMode.Impulse);
        }
    }
}
