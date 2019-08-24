using UnityEngine;
using System.Collections;
using TMPro;
public class ChooseItem : AbstractInfoClass
{
    [SerializeField]
    Item item;

    [SerializeField]
    TextMeshProUGUI count_text_ui;

    

    private void Start()
    {
       
        mainAlert = GameObject.Find("Canvas").GetComponent<MainAlerts>();
        _info_button.onClick.AddListener(OnInfo);
    }
    public override void OnInfo()
    {
        base.OnInfo();
    }

    public override void SetParams(string name, string desrc)
    {
        base.SetParams(name, desrc);
    }

    public void AddItemScriptableObject(Item item_to_add_d)
    {
        item = item_to_add_d;
    }

    public void UpdateCounttext()
    {
        count_text_ui.text = item.Count.ToString();
    }


}
