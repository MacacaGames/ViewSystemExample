using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_PageDropdown : ViewElementBehaviour
{
    [SerializeField]TMP_Dropdown pageDropdown; 
    [SerializeField] List<string> viewPageNames;
    private void Start()
    {
        SetDropdownOptions(viewPageNames);
        
        //register onValueChanged event
        pageDropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }
    void SetDropdownOptions(List<string> viewPageNames)
    {
        pageDropdown.ClearOptions();
        pageDropdown.AddOptions(viewPageNames);
    }
    void OnDropdownValueChanged(int index)
    {
        //change page based on dropdown value
        var pageName = pageDropdown.options[index].text;
        ViewController.FullPageChanger().SetPage(pageName).Show();
    }
    
}
