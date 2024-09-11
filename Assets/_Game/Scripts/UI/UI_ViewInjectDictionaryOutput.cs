using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ViewInjectDictionaryOutput : ViewElementBehaviour
{
    [ViewElementInject]
    string stringInject1, stringInject2, stringInject3;
    
    [SerializeField] TMP_Text outputText;
    [SerializeField] Button closeButton;
    protected override void Awake()
    {
        base.Awake();
        closeButton.onClick.AddListener(OnCloseButtonClicked);
    }

    public override void OnBeforeShow()
    {
        var output = $"stringInject1: {stringInject1}\nstringInject2: {stringInject2}\nstringInject3: {stringInject3}";
        outputText.text =  output;
    }
    
    void OnCloseButtonClicked()
    {
        ViewController.OverlayPageChanger().SetPage( ViewSystemScriptable.ViewPages.ViewInjectDictionaryOutput).Leave();
    }
    
    
}
