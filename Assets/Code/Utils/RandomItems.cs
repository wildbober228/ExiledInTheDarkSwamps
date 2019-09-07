using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomItems : MonoBehaviour
{

    public ItemsList GetRandomItems(ItemsList list_of_allitems, int chanse)
    {
        ItemsList list_of_random_items = new ItemsList();

        int random_int = Random.Range(0,101);

        for (int i = 0; i < list_of_allitems.GetList().Count; i++)
        {
            if(random_int <= chanse)
            {
                list_of_random_items.AddItemToStorage(list_of_allitems.GetList()[i]);
            }
        }

        return list_of_random_items;
    }
}
