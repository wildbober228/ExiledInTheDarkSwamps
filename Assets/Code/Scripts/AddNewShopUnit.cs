using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNewShopUnit : AbstractAddObject
{
    [SerializeField]
    List<GameObject> _listShopUnit;


    [Header("Debug Fields")]
    [SerializeField]
    ItemsList BerserkItems;
    [SerializeField]
    int[] a;
    private void Start()
    {
        AddObject("Berserk", "Very Angry Unit | Health - 10 ; Strengh - 2",0, BerserkItems, a);
        AddObject("NotBerserk", "Not Very Angry Unit | Health - 5 ; Strengh - 1", 1, BerserkItems, a);
    }

    /// <summary>
    /// add army_img to armylist
    /// </summary>
    /// <param name="name_unit"></param>
    /// <param name="description_army"></param>
    public GameObject AddObject(string name_unit, string description_army, int id, ItemsList itemstobuyUnit, int[] count_need_items)
    {
        GameObject go = Instantiate(_objectImg_prefab, _parent_obj);
        ChooseShopUnit _chooseShopUnit = go.GetComponent<ChooseShopUnit>();
        _chooseShopUnit.SetParams(name_unit, description_army);
        _chooseShopUnit.id_unit = id;
        _chooseShopUnit.SetItems(itemstobuyUnit, count_need_items);
        _listShopUnit.Add(go);
        return go;
    }
}
