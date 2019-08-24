using UnityEngine;
using System.Collections;

public class AbstractAddObject : MonoBehaviour
{
    public Transform _parent_obj;
    public GameObject _objectImg_prefab;

    public virtual GameObject AddObject(string name_object, string description_object) 
    {
        GameObject go = Instantiate(_objectImg_prefab, _parent_obj);
        //go.GetComponent<BuildFactory>().SetParams(name_object, description_object);
        return go;
    }

    /// <summary>
    /// add item to storage
    /// </summary>
    /// <param name="name_object"></param>
    /// <param name="description_object"></param>
    /// <param name="item_to_add"></param>
    /// <returns></returns>
    public virtual void AddObject(string name_object, string description_object, Item item_to_add, int count) 
    {
        GameObject go = Instantiate(_objectImg_prefab, _parent_obj);
        //go.GetComponent<BuildFactory>().SetParams(name_object, description_object);
        
    }
}
