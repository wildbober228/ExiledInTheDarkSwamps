using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using Assets.Code.Interface;
using System;

public class ChooseArmyUnit : AbstractInfoClass, IParseText
{
    public int id_unit;
    [SerializeField]
    TextMeshProUGUI _count_army;

    [SerializeField]
    Button _add_unit;
    [SerializeField]
    Button _remove_unit;

    IParseText parse = new ChooseArmyUnit();
    //ArmySize
    int IParseText.Parse_Count(ref int current_army_count, string n_parse)
    {
        string need_to_parse = n_parse;
        string max_army_count = "";
        string current_army_count_s = "";
        int help = 1000;
        for (int i = 0; i < need_to_parse.Length; i++)
        {
            if (need_to_parse[i] == '/')
            {
                help = i;
            }
            if (i > help)
            {
                max_army_count += need_to_parse[i];
            }
            else if (i < help)
            {
                current_army_count_s += need_to_parse[i];
            }
        }
        current_army_count = System.Int32.Parse(current_army_count_s);
        return System.Int32.Parse(max_army_count);
    }
    private void Start()
    {
        
        mainAlert = GameObject.Find("Canvas").GetComponent<MainAlerts>();
        _info_button.onClick.AddListener(OnInfo);

        _add_unit.onClick.AddListener(AddUnityToAllArmy);
        _remove_unit.onClick.AddListener(RemoveUnityFromAllArmy);
    }
    public void AddUnityToAllArmy()
    {
        int current = 0;
        int max = parse.Parse_Count(ref current,_count_army.text);
        if (current < max)
        {
            _count_army.text = current + 1 + "/" + max;
            Debug.Log("Army = " + _count_army.text);
        }
    }

    public void RemoveUnityFromAllArmy()
    {
        int current = 0;
        int max = parse.Parse_Count(ref current, _count_army.text);
        if (current != 0)
        {
            _count_army.text = current - 1 + "/" + max;
            Debug.Log("Army = " + _count_army.text);
        }
    }

    public void AddMaxUnit()
    {
        int current = 0;
        int max = parse.Parse_Count(ref current, _count_army.text) + 1;
        _count_army.text = current + "/" + max;
        Debug.Log("Army = " + _count_army.text);
    }

    public void RemoveMaxUnit()
    {
        int current = 0;
        int max = parse.Parse_Count(ref current, _count_army.text) -1;
        if (max != 0)
        {
            _count_army.text = current + "/" + max;
            Debug.Log("Army = " + _count_army.text);
        }
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
