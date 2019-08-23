using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class MainAlerts : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _storyText_UI;
    [SerializeField]
    Text _storyName_UI;

    [SerializeField]
    GameObject _panelInfoUI;


    public void ShowMainAlert(string alert_name, string alert_text)
    {
        _panelInfoUI.SetActive(true);
        _panelInfoUI.GetComponent<ChooseTypeOfPanelInfo>().ChooseTypeButton(ChooseTypeOfPanelInfo.TypeButton.Okey);
        _storyName_UI.text = alert_name;
        _storyText_UI.text = alert_text;
    }
}
