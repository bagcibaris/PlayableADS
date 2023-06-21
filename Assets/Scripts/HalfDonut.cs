using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonut : MonoBehaviour
{
    public GameObject HalfD;
    public Transform MovingS;

    void Start()
    {
        MovingS = HalfD.transform.Find("MovingStick");
      /*foreach(GameObject Obj in GameObject.FindGameObjectsWithTag("MovingStick"))
        {   
            HalfD[i] = Obj;
            i++;
        }   
        foreach (Transform child in transform)
        {
            if (child.tag == "MovingStick")
            {
                Children.Add(child.gameObject);
                Debug.Log(child.name);
            }
            
        } */
       
        //MovingS = HalfD.transform.Find("Half_Donut/MovingStick");
        //GameObject[] objects = GameObject.FindGameObjectsWithTag("MovingStick");
    }

   

    void Update()
    {
        MovingS.transform.Rotate(60 * Time.deltaTime, 0f, 0f, Space.Self);
    }
}
