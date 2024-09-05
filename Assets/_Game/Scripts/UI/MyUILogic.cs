// Is require a child class of ViewElementBehaviour

using System;
using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MyUILogic : MonoBehaviour,IViewElementLifeCycle{
    [OverrideProperty("Frame", typeof(UnityEngine.UI.Image), nameof(UnityEngine.UI.Image.sprite)) ]
    [SerializeField]
    Sprite someSprite;
    [SerializeField] 
    ViewElementOverride itemEnabledOverride, itemDisabledOverride;
    [SerializeField] 
    Button switchItemButton;
    [SerializeField] 
    ViewElement viewElement;
    [SerializeField]
    TMP_Text logText;
    
    // [OverrideButtonEvent("Content/CustomEventButton")]
    // void CustomOverrideFunction(Component component )
    // {
    //     var log = "trigger CustomOverrideFunction, this on click event is override via script";
    //     Debug.Log(log);
    // }
    
    void Awake()
    {
        switchItemButton.onClick.AddListener(SwitchItemOverride);
    }
    bool isItemEnabled = true;
    void SwitchItemOverride()
    {
        isItemEnabled = !isItemEnabled;
        if (isItemEnabled)
        {
            viewElement.ApplyOverrides(itemEnabledOverride);
            
            logText.text = "Current ViewElementOverride:\n itemEnabledOverride";
        }
        else
        {
            viewElement.ApplyOverrides(itemDisabledOverride);
            
            logText.text = "Current ViewElementOverride:\n itemDisabledOverride";
        }
    }

    public void OnBeforeShow()
    {
        Debug.Log("OnBeforeShow");
    }
    public void OnBeforeLeave()
    {
        Debug.Log("OnBeforeLeave");
    }
    public void OnStartShow()
    {
        Debug.Log("OnStartShow");
    }
    public void OnStartLeave()
    {
        Debug.Log("OnStartLeave");
    }
    public void OnChangePage(bool show)
    {
        Debug.Log("OnChangePage");
    }
    public void OnChangedPage()
    {
        Debug.Log("OnChangedPage");
    }
    public void RefreshView()
    {
        Debug.Log("OnChangedPage");
    }
}