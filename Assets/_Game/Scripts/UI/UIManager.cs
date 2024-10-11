using UnityEngine;
using MacacaGames.ViewSystem;

public class UIManager : MonoBehaviour
{
    [ViewSystemEvent("OverridePropertyPage")]
    public void OnOverridePropertyPageBtnPressed(Component c)
    {
        var messageBoxCoroutine = UI_MessageBox.Show("Title", "By editing the event override for this button in the View System Visual Editor, the button's onClick now calls OnOverridePropertyPageBtnPressed() in the UIManager.cs",
            new UI_MessageBox.BtnWrapper[]{
                new UI_MessageBox.BtnWrapper{
                    text = "Confirm",
                    OnClick = ()=>{ },
                    color = UI_MessageBox.BtnColor.Success,
                    interactable = true
                }
            }
        );
    }
    [ViewSystemEvent("PageChange")]
    public void GoToCharacterUpgradePage(Component c)
    {
        ViewController.FullPageChanger()
            .SetPage("CharacterUpgrade")
            .Show();
    }

}
