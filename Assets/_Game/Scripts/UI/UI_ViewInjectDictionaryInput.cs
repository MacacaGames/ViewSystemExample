using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using MacacaGames.GameSystem;
using MacacaGames.ViewSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ViewInjectDictionaryInput : ViewElementBehaviour
{
    // [SerializeField] GameObject inputPairPrefab;
    // [SerializeField] Transform inputPairParent;
    [SerializeField] Button sendButton;
    [SerializeField] List<InputPair> inputPairs;

    protected override void Awake()
    {
        base.Awake();
        sendButton.onClick.AddListener(OnSendButtonClicked);
    }
    // void OnAddPairButtonClicked()
    // {
    //     var newPair = Instantiate(inputPairPrefab, inputPairParent).GetComponent<InputPair>();
    //     inputPairs.Add(newPair);
    // }
    // void OnRemovePairButtonClicked()
    // {
    //     if(inputPairs.Count == 0 || inputPairs.Count > 3) return;

    //     var pair = inputPairs[inputPairs.Count-1];
    //     inputPairs.RemoveAt(inputPairs.Count-1);
    //     Destroy(pair.gameObject);
    // }
    
    void OnSendButtonClicked()
    {
        var datas = new ViewInjectDictionary<string>();
        foreach (var pair in inputPairs)
        {
            datas.TryAdd(pair.key.text, pair.value.text);
        }

        ViewController.OverlayPageChanger().SetPage(ViewSystemScriptable.ViewPages.ViewInjectDictionaryOutput).SetPageModel(datas).Show();
    }
}

