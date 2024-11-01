using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ViewElementInjectOutput : ViewElementBehaviour
{
    [ViewElementInject]
    int injectInt;
    
    [SerializeField] TMP_Text outputText;
    [SerializeField] Button closeButton;
    protected override void Awake()
    {
        base.Awake();
        closeButton.onClick.AddListener(OnCloseButtonClicked);
    }

    public override void OnBeforeShow()
    {
        outputText.text =  injectInt.ToString();
    }
    
    void OnCloseButtonClicked()
    {
        ViewController.OverlayPageChanger().SetPage(ViewSystemScriptable.ViewPages.ViewElementInjectOutput).Leave();
    }
    
    
}
