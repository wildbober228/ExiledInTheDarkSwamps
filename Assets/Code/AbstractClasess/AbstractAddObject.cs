using UnityEngine;
using System.Collections;

public class AbstractAddObject : MonoBehaviour
{
    public Transform _parent_obj;
    public GameObject _objectImg_prefab;

    public virtual GameObject AddObject(string name_object, string description_object) // also need to add list of needble items to build this factory
    {
        GameObject go = Instantiate(_objectImg_prefab, _parent_obj);
        //go.GetComponent<BuildFactory>().SetParams(name_object, description_object);
        return go;
    }
}
