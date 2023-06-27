using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    public List<GameObject> objects;
    public List<GameObject> uiObjects;
    
        void Update()
        {
            
            var objects2 = objects.SortByDistance(new Vector3(0, 0.1f, 12.75f));
            //objects.Reverse();
            uiObjects[0].transform.SetSiblingIndex(objects2.IndexOf(objects[0]));
            uiObjects[1].transform.SetSiblingIndex(objects2.IndexOf(objects[1]));
            uiObjects[2].transform.SetSiblingIndex(objects2.IndexOf(objects[2]));
            uiObjects[3].transform.SetSiblingIndex(objects2.IndexOf(objects[3]));
            uiObjects[4].transform.SetSiblingIndex(objects2.IndexOf(objects[4]));
        }       
}
