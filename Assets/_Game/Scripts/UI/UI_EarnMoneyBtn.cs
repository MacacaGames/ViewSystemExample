using MacacaGames.GameSystem;
using MacacaGames.ViewSystem;
using UnityEngine;
using UnityEngine.UI;
public class UI_EarnMoneyBtn : ViewElementBehaviour
{
    [SerializeField] Button button;
    public void Awake()
    {
        button.onClick.AddListener(OnClick);
    }
    int earnMoneyAmount = 100;
    void OnClick()
    {
        var currencyBar =  ViewController.Instance.GetSingletonViewElement<UI_CurrencyBar>();
        if(currencyBar == null)
        {
            Debug.LogError("CurrencyBar not found");
            return;
        }

        var currentCoin = currencyBar.GetCurrentCoin();
        currencyBar.SetCoin(currentCoin + earnMoneyAmount);
        Debug.Log($"Earn Money:{currentCoin} -> {currentCoin + earnMoneyAmount}");
    }

}