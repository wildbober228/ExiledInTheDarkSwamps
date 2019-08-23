using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class AddNewItemToStorage : AbstractAddObject
{
    public ItemsList Items;
    [SerializeField]
    AllGameItems _all_game_items;

    bool can_spawn_newItem = true;
    private void Start()
    {
        
        AddObject("Dirty Water","Use to create a field of beryes", _all_game_items.GetTestItem());
    }

    public override GameObject AddObject(string name_object, string description_object, Item item_to_addd)
    {
        can_spawn_newItem = true;
        ChooseItem chooseItem = null;
        foreach (Item item in Items.Items)
        {
            Debug.Log("ItemIdInStorage = "+ item.Id);
            Debug.Log("item_to_addd = " + item_to_addd.Id);
            if (item.Id == item_to_addd.Id)
            {
                Debug.Log("Point are here");
                item.AddCountItem(item_to_addd.Count);
                can_spawn_newItem = false;
                chooseItem = item.Chooseitem;
                chooseItem.UpdateCounttext();
                break;
            }
        }
        if (can_spawn_newItem)
        {
            GameObject go = base.AddObject(name_object, description_object);
            chooseItem = go.GetComponent<ChooseItem>();

            chooseItem.SetParams(name_object, description_object);
            chooseItem.AddItemScriptableObject(item_to_addd);
            item_to_addd.Chooseitem = chooseItem;
            Items.AddItemToStorage(item_to_addd);
            return go;
        }
        else
        {
            return chooseItem.gameObject;
        }
    }
}
