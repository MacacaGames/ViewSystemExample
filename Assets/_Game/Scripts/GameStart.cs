using System.Collections;
using System.Collections.Generic;
using MacacaGames.ViewSystem;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    void Awake()
    {
        ViewController
            .FullPageChanger()
            .SetPage(ViewSystemScriptable.ViewPages.OverrideProperty)
            .Show();
    }
}
