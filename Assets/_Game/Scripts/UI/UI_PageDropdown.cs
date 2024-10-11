using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_PageDropdown : ViewElementBehaviour, IViewElementSingleton
{
    [SerializeField]TMP_Dropdown pageDropdown; 
    [SerializeField] List<string> viewPageNames;
    [SerializeField] Button nextPageButton;

    int lastPageIndex = 0;

    private void Start()
    {
        SetDropdownOptions(viewPageNames);
        
        //register events
        pageDropdown.onValueChanged.AddListener(OnDropdownValueChanged);
        nextPageButton.onClick.AddListener(OnNextPageButtonClicked);
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

        //save last page index
        lastPageIndex = index;
    }

    void OnNextPageButtonClicked()
    {
        //change page based on dropdown value
        lastPageIndex++;
        if (lastPageIndex >= pageDropdown.options.Count)
        {
            lastPageIndex = 0;
        }
        pageDropdown.value = lastPageIndex;
    }
    
}
