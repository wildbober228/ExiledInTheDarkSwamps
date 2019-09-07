using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class AddNewItemToStorage : AbstractAddObject
{
    public ItemsList Items;
    [SerializeField]
    Dictionary<int, ChooseItem> _save_chooseitems = new Dictionary<int, ChooseItem>();
    [SerializeField]
    Dictionary<int, Item> _save_items_with_id = new Dictionary<int, Item>();

    [SerializeField]
    AllGameItems _all_game_items;

    bool can_spawn_newItem = true;
    private void Start()
    {
        
        //AddObject("Dirty Water","Use to create a field of beryes", _all_game_items.GetTestItem(),103);
    }

    public void SetCount(int id, int count)
    {
        _save_items_with_id[id].AddCountItem(count);
        _save_chooseitems[id].UpdateCounttext();
    }

    public override void AddObject(string name_object, string description_object, Item item_to_addd, int count)
    {
        can_spawn_newItem = true;
        ChooseItem chooseItem = null;
        //Debug.Log("Point 0 key = "+ _save_items_with_id[item_to_addd.Id].Id);
        if (_save_items_with_id.ContainsKey(item_to_addd.Id))
        {
            can_spawn_newItem = false;
            
            SetCount(item_to_addd.Id, count);
        }
        if (can_spawn_newItem)
        {
            GameObject go = base.AddObject(name_object, description_object);
            chooseItem = go.GetComponent<ChooseItem>();

            chooseItem.SetParams(name_object, description_object);
            chooseItem.AddItemScriptableObject(item_to_addd);
           
            Items.AddItemToStorage(item_to_addd);

            _save_chooseitems.Add(item_to_addd.Id, chooseItem);           
            _save_items_with_id.Add(item_to_addd.Id, item_to_addd);
          
            SetCount(item_to_addd.Id,count);         
        }            
    }

    public bool GetItem(Item item_to_check, int count)
    {
        if (_save_items_with_id.ContainsKey(item_to_check.Id))
        {
            if(_save_items_with_id[item_to_check.Id].Count >= count)
            {
                //save_items_with_id[item_to_check.Id].AddCountItem(-count);
                return true;
            }
            else
            {
                Debug.Log("Dont have enuf items" + "id_c"+ _save_items_with_id[item_to_check.Id].Count + "id "+ count);
                return false;
            }
        }
        else
        {
            Debug.Log("Dont have this type items");
            return false;
        }
    }

    
}
