using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class AddNewArmyUnit : AbstractAddObject
{
    [SerializeField]
    List<GameObject> _armyUnits_list;

    


    bool create_new_unit = true;
    private void Start()
    {
      
        //GameObject go = AddObject("Warrior", "VeryStarngeUnit",0);
        //GameObject go1 = AddObject("Warrior", "VeryStarngeUnit", 0);
        //GameObject go21 = AddObject("Warrior", "VeryStarngeUnit", 0);
        //GameObject go2 = AddObject("Warrior", "VeryStarngeUnit", 0);
        //GameObject go3 = AddObject("Warrior", "VeryStarngeUnit", 2);
        //GameObject go4 = AddObject("Warrior", "VeryStarngeUnit", 2);
    }

    /// <summary>
    /// add unit_img to list
    /// </summary>
    /// <param name="name_factory"></param>
    /// <param name="description_factory"></param>
    public GameObject AddObject(string name_unit, string description_unit, int id_unit) // also need to add index unit
    {
        create_new_unit = true;
        ChooseArmyUnit unit_old = null;
        for (int i = 0; i < _armyUnits_list.Count; i++)
        {
            if(_armyUnits_list[i].GetComponent<ChooseArmyUnit>().id_unit == id_unit)
            {
                unit_old = _armyUnits_list[i].GetComponent<ChooseArmyUnit>();
                _armyUnits_list.Add(unit_old.gameObject);
                unit_old.AddMaxUnit();
                create_new_unit = false;
                break;
            }
        }
        if (create_new_unit == true)
        {
            GameObject go = Instantiate(_objectImg_prefab, _parent_obj);
            ChooseArmyUnit unit = go.GetComponent<ChooseArmyUnit>();
            unit.SetParams(name_unit, description_unit);
            unit.id_unit = id_unit;
            unit.AddMaxUnit();
            _armyUnits_list.Add(go);
            return go;
        }
        else
        {
            return unit_old.gameObject;
        }
        
    }
}
