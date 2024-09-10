using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using MacacaGames.GameSystem;
using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ViewElementInjectInput : ViewElementBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] Button sendButton;

    protected override void Awake()
    {
        base.Awake();
        sendButton.onClick.AddListener(OnSendButtonClicked);
    }
    
    void OnSendButtonClicked()
    {
        var inputText = inputField.text;
        ViewController.OverlayPageChanger().SetPage("ViewElementInjectOutput").SetPageModel(inputText).Show();
    }
}
