using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name.Equals("Boy"))
        {
            other.gameObject.transform.parent = null;
            other.gameObject.transform.position = new Vector3 (0f, 0f, -6.6f);
        }    
    } 
}
