using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AddNewWork : AbstractAddObject
{
    [SerializeField]
    List<GameObject> works_list;

    [SerializeField]
    Item test_item;
    private void Start()
    {
        AddObject("Fill water in the Lake", "Add 1 dirty water. needto craft place with bears",test_item,5);
    }

    /// <summary>
    /// add location_img to list
    /// </summary>
    /// <param name="name_work"></param>
    /// <param name="description_work"></param>
    public override void AddObject(string name_work, string description_work, Item item_to_mine,int count_item_per_mine)
    {
        GameObject go = Instantiate(_objectImg_prefab, _parent_obj);
        StartWork work = go.GetComponent<StartWork>();
        work.SetParams(name_work, description_work);
        work.AddMineItem(item_to_mine, count_item_per_mine);
        works_list.Add(go);
    }
}
