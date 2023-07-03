using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCount : MonoBehaviour
{
    public static CoinCount instance;
    public TextMeshProUGUI coinCount;
    int coin = 0;

    private void Awake() 
    {
        instance = this;    
    }
    void Start()
    {
        coinCount.text = coin.ToString() + " COIN";
    }

    public void AddCoin()
    {
        coin += 1;
        coinCount.text = coin.ToString() + " COIN";
    }
}
