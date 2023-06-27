using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{

    public GameObject RotatingP;
    public Transform purple;
    public Transform yellow;
    public Transform blue;

    void Start()
    {
        purple = RotatingP.transform.Find("PurpleRotatingPlatform");
        yellow = RotatingP.transform.Find("YellowRotatingPlatform");
        blue = RotatingP.transform.Find("BlueRotatingPlatform");
    }
    


    void Update() 
    {
        purple.transform.Rotate(0f, 0f, 30 * Time.deltaTime, Space.Self);
        yellow.transform.Rotate(0f, 0f, -30 * Time.deltaTime, Space.Self);
        blue.transform.Rotate(0f, 0f, 30 * Time.deltaTime, Space.Self);

    }


    private void OnCollisionStay(Collision other) {
        if(other.gameObject.name.Equals("Boy")){
            Debug.Log("deneme!");
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * 50);
        }
    }

    void FixedUpdate() {
        
    }
}
