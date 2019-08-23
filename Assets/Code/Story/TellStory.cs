using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TellStory : MonoBehaviour
{
    
    [SerializeField]
    TextMeshProUGUI _storyText_UI;
    [SerializeField]
    Text _storyName_UI;

    [SerializeField]
    string _storyName;
    [TextArea]
    [SerializeField]
    string _storytext;

    [SerializeField]
    GameObject _panelInfoUI;

    [SerializeField]
    MainAlerts mainAlerts;

    void Start()
    {
#if !UNITY_EDITOR
        if (PlayerPrefs.GetString("Story") != "True")
        {
            PlayerPrefs.SetString("Story", "True");
            ShowStory();
        }
#else
        PlayerPrefs.DeleteAll();
        ShowStory();
    #endif

    }

    void ShowStory()
    {
        mainAlerts.ShowMainAlert(_storyName, _storytext);
        //_panelInfoUI.SetActive(true);
        //_panelInfoUI.GetComponent<ChooseTypeOfPanelInfo>().ChooseTypeButton(ChooseTypeOfPanelInfo.TypeButton.Okey);
        ////GetComponent Script . Okey == true
        //_storyName_UI.text = _storyName;
        //_storyText_UI.text = _storytext;
    }
}
