using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorRotate : MonoBehaviour
{
    public GameObject RotatingStick;
    public Transform rotator1;
    public Transform rotator2;
    public Transform rotator3;
    public Transform rotator4;


    void Start()
    {
        rotator1 = RotatingStick.transform.Find("Rotator (1)");
        rotator2 = RotatingStick.transform.Find("Rotator (2)");
        rotator3 = RotatingStick.transform.Find("Rotator (3)");
        rotator4 = RotatingStick.transform.Find("Rotator (4)");

    }

    void Update()
    {
        rotator1.transform.Rotate(0f, 25 * Time.deltaTime, 0f, Space.Self);
        rotator2.transform.Rotate(0f, -25 * Time.deltaTime, 0f, Space.Self);
        rotator3.transform.Rotate(0f, 25 * Time.deltaTime, 0f, Space.Self);
        rotator4.transform.Rotate(0f, -25 * Time.deltaTime, 0f, Space.Self);
    }
}
