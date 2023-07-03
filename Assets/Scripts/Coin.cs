using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    bool isCollected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isCollected){
                        Vector3 screenPoint = GameObject.Find("CoinUI").transform.position + new Vector3(0,0,5);  //the "+ new Vector3(0,0,5)" ensures that the object is so close to the camera you dont see it
			
			//find out where this is in world space
			Vector3 worldPos = Camera.main.ScreenToWorldPoint( screenPoint );
			
			//move towards the world space position
			transform.DOMove(worldPos,2);
        }


    }

    private void OnTriggerEnter(Collider other) {
            if(other.gameObject.name.Equals("Boy"))
            {
                isCollected = true;
                CoinCount.instance.AddCoin();
            }
    }
}
