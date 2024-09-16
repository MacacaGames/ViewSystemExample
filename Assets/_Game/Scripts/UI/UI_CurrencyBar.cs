using System.Collections;
using System.Collections.Generic;
using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;

public class UI_CurrencyBar : ViewElementBehaviour , IViewElementSingleton
{
    [SerializeField] TextMeshProUGUI coinText;
    int coin = 100;
    private void Start() {
        coinText.text = coin.ToString();
    }

    public int GetCurrentCoin()
    {
       return coin;
    }
    public void SetCoin(int value)
    {
        coin = value;
        coinText.text = coin.ToString();
    }

}
