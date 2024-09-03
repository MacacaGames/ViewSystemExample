using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_PageDropdown : ViewElementLifeCycle
{
    [SerializeField]TMP_Dropdown pageDropdown; 
    private void Start()
    {
        var viewPageNames = ViewController.Instance.currentViewState.viewPageItems.Select(x => x.name).ToArray();
        SetDropdownOptions(viewPageNames);
        
        //register onValueChanged event
        pageDropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }
    void SetDropdownOptions(string[] viewPageNames)
    {
        pageDropdown.ClearOptions();
        pageDropdown.AddOptions(viewPageNames.ToList());
    }
    void OnDropdownValueChanged(int index)
    {
        //change page based on dropdown value
        var pageName = pageDropdown.options[index].text;
        ViewController.FullPageChanger().SetPage(pageName).Show();
    }
    
}
