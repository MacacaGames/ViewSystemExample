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
    [SerializeField] TMP_InputField stringInputField,intInputField;
    [SerializeField] Button sendButton;

    protected override void Awake()
    {
        base.Awake();
        sendButton.onClick.AddListener(OnSendButtonClicked);
    }
    
    void OnSendButtonClicked()
    {
        var inputText = stringInputField.text;
        if(int.TryParse(intInputField.text, out var inputInt) == false)
        {
            Debug.LogError("Input int is not a number");
            return;
        }
        ViewController.OverlayPageChanger().SetPage(ViewSystemScriptable.ViewPages.ViewElementInjectOutput).SetPageModel(inputText,inputInt).Show();
    }
}
