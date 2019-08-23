using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class BuildFactory : AbstractInfoClass
{
   
    [SerializeField]
    Button _build_button;
  
   
    

    [Header("Unity Params")]
   

    [SerializeField]
    string alert_name_success;
    [SerializeField]
    [TextArea]
    string alert_text_success;


    /// <summary>
    /// test bool
    /// </summary>
    bool can_build = true;

    void SuccessBuild()
    {
        mainAlert.ShowMainAlert(alert_name_success, alert_text_success);
    }

    void CantBuild()
    {

    }

    private void OnBuild()// also need to add list of needble items to build this factory
    {
        if (can_build)
        {
            SuccessBuild();
        }
        else
        {
            CantBuild();
        }
    }

    public override void OnInfo()
    {
        mainAlert.ShowMainAlert(info_name_header +" "+ _name_object.text, info_description_main_text);
    }

    private void Start()
    {
        mainAlert = GameObject.Find("Canvas").GetComponent<MainAlerts>();
        _build_button.onClick.AddListener(OnBuild);
        _info_button.onClick.AddListener(OnInfo);
       
    }

    public override void SetParams(string name, string desrc)
    {
        base.SetParams(name,desrc);
    }
}
