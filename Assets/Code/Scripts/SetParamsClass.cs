using UnityEngine;
using System.Collections;
using TMPro;
public class SetParamsClass : AbstractInfoClass
{
    [SerializeField]
    TextMeshProUGUI count_item;

    private void Start()
    {
        mainAlert = GameObject.Find("Canvas").GetComponent<MainAlerts>();
    }


    public override void SetParams(string name, string desrc)
    {
        base.SetParams(name, desrc);
        count_item.text = info_description_main_text;
    }
}
