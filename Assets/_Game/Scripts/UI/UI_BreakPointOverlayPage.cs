using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UI_BreakPointOverlayPage : ViewElementBehaviour
{
    [SerializeField] Button closeButton;
    protected override void Awake()
    {
        base.Awake();
        closeButton.onClick.AddListener(OnCloseButtonClicked);
    }
    
    void OnCloseButtonClicked()
    {
        ViewController.OverlayPageChanger().SetPage( ViewSystemScriptable.ViewPages.BreakPointOverlayPage).Leave();
    }
}