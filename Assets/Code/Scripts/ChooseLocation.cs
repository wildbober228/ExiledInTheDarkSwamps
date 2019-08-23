using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class ChooseLocation : AbstractInfoClass
{
    [SerializeField]
    Button _chooselocation_button;
    [SerializeField]
    TextMeshProUGUI _name_location_ui;

    private void Start()
    {
        _name_location_ui = GameObject.Find("NameLocation").GetComponent<TextMeshProUGUI>();
        mainAlert = GameObject.Find("Canvas").GetComponent<MainAlerts>();
        _info_button.onClick.AddListener(OnInfo);
        _chooselocation_button.onClick.AddListener(OnChoose);
    }

    public void OnChoose()
    {
        _name_location_ui.text = base.info_name_header;
    }

    public override void OnInfo()
    {
        base.OnInfo();    
    }
    public override void SetParams(string name, string desrc)
    {
        base.SetParams(name, desrc);
    }
}
