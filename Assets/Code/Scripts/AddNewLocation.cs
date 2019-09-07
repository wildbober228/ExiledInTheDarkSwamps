using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AddNewLocation : AbstractAddObject
{
    [SerializeField]
    List<GameObject> locations_list;


    private void Start()
    {
        //AddObject("FairyRiver", "Very Dangeres Place. Be carefull");
    }

    /// <summary>
    /// add location_img to list
    /// </summary>
    /// <param name="name_location"></param>
    /// <param name="description_location"></param>
    public override GameObject AddObject(string name_location, string description_location)
    {
        GameObject go = Instantiate(_objectImg_prefab, _parent_obj);
        go.GetComponent<ChooseLocation>().SetParams(name_location, description_location);
        locations_list.Add(go);
        return go;
    }
}
