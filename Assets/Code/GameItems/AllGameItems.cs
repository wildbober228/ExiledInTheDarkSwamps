using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/ALLItemsList")]
class AllGameItems : ScriptableObject
{
    
    [SerializeField] private List<Item> Items_inGame;

    public Item GetTestItem()
    {
        return Items_inGame[0];
    }
}

