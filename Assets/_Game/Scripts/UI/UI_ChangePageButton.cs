
using System;
using MacacaGames.ViewSystem;
using UnityEngine;
using UnityEngine.UI;
public class UI_ChangePageButton : ViewElementBehaviour
{
    [SerializeField] string pageName;
    [SerializeField] TMPro.TextMeshProUGUI text;
    private void Awake() 
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }
    public override void OnStartShow()
    {
        base.OnStartShow();
        text.text = "To Page: \n" + pageName;
    }
    void OnClick()
    {
        if(ViewController.Instance.IsViewPageExsit(pageName) == false)
        {
            Debug.LogError("Change page fail, page not found: " + pageName);
            return;
        }
        ViewController.FullPageChanger().SetPage(pageName).Show();
    }
}