using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ViewElementInjectOutput : ViewElementBehaviour
{
    [ViewElementInject]
    public string injectString;
    
    [SerializeField] TMP_Text outputText;
    [SerializeField] Button closeButton;
    protected override void Awake()
    {
        base.Awake();
        closeButton.onClick.AddListener(OnCloseButtonClicked);
    }

    public override void OnBeforeShow()
    {
        outputText.text = "Received ViewElementInject: \n" + injectString;
    }
    
    void OnCloseButtonClicked()
    {
        ViewController.OverlayPageChanger().SetPage("ViewElementInjectOutput").Leave();
    }
    
    
}
