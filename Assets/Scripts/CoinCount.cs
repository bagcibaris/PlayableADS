using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCount : MonoBehaviour
{
    public TextMeshProUGUI coinCount;
    int coin = 0;
    void Start()
    {
        coinCount.text = coin.ToString() + " COIN";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
