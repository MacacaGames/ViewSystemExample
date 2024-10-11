using System.Collections;
using System.Collections.Generic;
using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class BreakpointControl : MonoBehaviour
{
    [SerializeField]
    Button applyBreakPointBtn, removeBreakPointBtn, showPageBtn;
    [SerializeField]
    TMP_InputField applyInputField, removeInputField;
    [SerializeField] 
    TMP_Text activeBreakPointText;
    private void Awake() 
    {
        applyBreakPointBtn.onClick.AddListener(ApplyBreakPoint);
        removeBreakPointBtn.onClick.AddListener(RemoveBreakPoint);
        showPageBtn.onClick.AddListener(ShowBreakPointOverlayPage);
    }

    void ApplyBreakPoint()
    {
        ViewController.Instance.SetBreakPoint(applyInputField.text);
        RefreshActiveBreakPoint();
    }
    void RemoveBreakPoint()
    {
        ViewController.Instance.RemoveBreakPoint(removeInputField.text);
        RefreshActiveBreakPoint();
    }
    void RefreshActiveBreakPoint()
    {
        var breakPoints = ViewController.Instance.GetActiveBreakPoints();
        //join all break points
        var text = string.Join("\n", breakPoints);
        activeBreakPointText.text = text;
    }
    void ShowBreakPointOverlayPage()
    {
        ViewController.OverlayPageChanger().SetPage(ViewSystemScriptable.ViewPages.BreakPointOverlayPage).Show();
    }

}
