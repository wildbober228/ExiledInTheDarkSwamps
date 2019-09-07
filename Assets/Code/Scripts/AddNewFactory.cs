using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNewFactory : AbstractAddObject
{


    [SerializeField]
    List<GameObject> factory_list;


    private void Start()
    {
        //GameObject go = AddObject("Factory Wood","In this factory you can mine wood");
    }

    /// <summary>
    /// add factory_img to list
    /// </summary>
    /// <param name="name_factory"></param>
    /// <param name="description_factory"></param>
    public override GameObject AddObject(string name_factory, string description_factory) // also need to add list of needble items to build this factory
    {
        GameObject go = Instantiate(_objectImg_prefab,_parent_obj);
        go.GetComponent<BuildFactory>().SetParams(name_factory, description_factory);
        factory_list.Add(go);
        return go;
    }
}
