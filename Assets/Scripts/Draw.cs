using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    public GameObject Brush;


    private void Update()
    {
        if(Input.GetMouseButton(0))
        {

        }    
    }

/*     private LineRenderer line;
    private Vector3 previousPosition;
    [SerializeField]
    private float minDistance = 0.1f;
    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 1;
        previousPosition = transform.position;    
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;

            if(Vector3.Distance(currentPosition, previousPosition) > minDistance)
            {
                if(previousPosition == transform.position)
                {
                    line.SetPosition(0, currentPosition);
                }
                else
                {
                    line.positionCount++;
                    line.SetPosition(line.positionCount - 1, currentPosition);
                }

                previousPosition = currentPosition;
            }
        }
    } */
}
