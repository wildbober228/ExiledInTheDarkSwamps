using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class AbstractInfoClass : MonoBehaviour
{

    public MainAlerts mainAlert;
    public Button _info_button;

    public TextMeshProUGUI _name_object;

    [Header("Unity Params")]
    public string info_name_header;
    public string info_description_main_text;

    private void Start()
    {
        _name_object = this.gameObject.GetComponent<TextMeshProUGUI>();
        mainAlert = GameObject.FindGameObjectWithTag("Canvas").GetComponent<MainAlerts>();
    }
    public virtual void OnInfo()
    {
        mainAlert.ShowMainAlert(_name_object.text, info_description_main_text);
    }

    public virtual void SetParams(string name, string desrc)
    {
        _name_object.text = name;
        info_name_header = name;
        info_description_main_text = desrc;
    }
}
