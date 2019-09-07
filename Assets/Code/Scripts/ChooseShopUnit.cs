using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChooseShopUnit : AbstractInfoClass
{
    public int id_unit;

    [SerializeField]
     TextMeshProUGUI _Infotext;

    [SerializeField]
    Button _buyUnit;


    [Header("Items need to buy this Unit")]
    [SerializeField]
    ItemsList _needItemsToBuy;
    [SerializeField]
    int[] _countItemsToBuyUnit;


    [Header("Add Scripts settings")]
    [SerializeField]
    AddNewArmyUnit _addNewArmyUnit;
    [SerializeField]
    AddNeedItemsToBuyUnit _addNeedItemsToBuyUnit;
    [SerializeField]
    AddNewItemToStorage _addNewItemToStorage;

    private void Start()
    {       
        mainAlert = GameObject.Find("Canvas").GetComponent<MainAlerts>();
        _addNewArmyUnit = GameObject.FindWithTag("Panel_Right").GetComponent<AddNewArmyUnit>();
        _addNewItemToStorage = GameObject.FindWithTag("ItemsStorage").GetComponent<AddNewItemToStorage>();
        _info_button.onClick.AddListener(OnInfo);
        _buyUnit.onClick.AddListener(BuyUnit);
        // Debug.Log(_needItemsToBuy._items_inStorage[0].name);
        Debug.Log(_needItemsToBuy.GetList()[0].name);
        for (int i = 0; i < _countItemsToBuyUnit.Length; i++)
        {      
            _addNeedItemsToBuyUnit.AddObject(_needItemsToBuy.GetList()[i].name, _countItemsToBuyUnit[i].ToString());
        }
        
        this.OnInfo();

    }

    void BuyUnit()
    {
        int count_truebool = 0;
        for (int i = 0; i < _countItemsToBuyUnit.Length; i++)
        {
            if (_addNewItemToStorage.GetItem(_needItemsToBuy.GetList()[i], _countItemsToBuyUnit[i]))
            {
                count_truebool += 1;
                
            }              
        }

        if (count_truebool == _countItemsToBuyUnit.Length)
        {
            _addNewArmyUnit.GetComponent<AddNewArmyUnit>().AddObject(info_name_header, info_description_main_text, id_unit);
            for (int i = 0; i < _countItemsToBuyUnit.Length; i++)
            {
                _addNewItemToStorage.AddObject(_needItemsToBuy.GetList()[i].name, _countItemsToBuyUnit[i].ToString(), _needItemsToBuy.GetList()[i], -_countItemsToBuyUnit[i]);
            }
            Debug.Log("Unit Succes buy");
        }
    }

    public void SetItems(ItemsList listitems, int[] count_items)
    {
        _needItemsToBuy = listitems;
        _countItemsToBuyUnit = count_items;
    }

    public override void OnInfo()
    {
        _Infotext.text = info_description_main_text;
    }
    public override void SetParams(string name, string desrc)
    {
        base.SetParams(name, desrc);
    }
}
