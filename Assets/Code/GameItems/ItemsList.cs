using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/ItemsList")]
public class ItemsList : ScriptableObject
{
    [SerializeField]
    private List<Item> _items_inStorage;

    public IEnumerable<Item> Items => _items_inStorage;

    public void AddItemToStorage(Item item)
    {
        _items_inStorage.Add(item);
        Debug.Log("Add new Item to Storage");
    }

    private void OnDisable()
    {
        _items_inStorage.Clear();
    }
}
