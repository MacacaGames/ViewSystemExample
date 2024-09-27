using System.Collections;
using System.Collections.Generic;
using MacacaGames.ViewSystem;
using UnityEngine;
using UnityEngine.UI;
public class BreakpointControl : MonoBehaviour
{
    [SerializeField]Button applyBreakPointBtn, removeBreakPointBtn;
    [SerializeField]TMPro.TMP_InputField applyInputField, removeInputField;
    private void Awake() 
    {
        applyBreakPointBtn.onClick.AddListener(ApplyBreakPoint);
        removeBreakPointBtn.onClick.AddListener(RemoveBreakPoint);
    }

    void ApplyBreakPoint()
    {
        ViewController.Instance.SetBreakPoint(applyInputField.text);
    }
    void RemoveBreakPoint()
    {
        ViewController.Instance.RemoveBreakPoint(removeInputField.text);
    }

}
