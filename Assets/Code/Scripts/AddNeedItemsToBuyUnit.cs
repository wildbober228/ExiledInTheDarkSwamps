using UnityEngine;
using System.Collections;

public class AddNeedItemsToBuyUnit : AbstractAddObject
{
    /// <summary>
    /// add factory_img to list
    /// </summary>
    /// <param name="name_item"></param>
    public override GameObject AddObject(string name_item, string count_to_need)
    {
        GameObject go =  base.AddObject(name_item, count_to_need);
        go.GetComponent<SetParamsClass>().SetParams(name_item, count_to_need);
        return go;
    }
}
