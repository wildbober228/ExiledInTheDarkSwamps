using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AddNewWork : AbstractAddObject
{
    [SerializeField]
    List<GameObject> works_list;


    private void Start()
    {
        AddObject("FairyRiver", "Very Dangeres Place. Be carefull");
    }

    /// <summary>
    /// add location_img to list
    /// </summary>
    /// <param name="name_work"></param>
    /// <param name="description_work"></param>
    public override GameObject AddObject(string name_work, string description_work)
    {
        GameObject go = Instantiate(_objectImg_prefab, _parent_obj);
        go.GetComponent<StartWork>().SetParams(name_work, description_work);
        works_list.Add(go);
        return go;
    }
}
