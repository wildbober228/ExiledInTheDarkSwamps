using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/GameItemsList")]
class GameItemsList : ScriptableObject
{
    [SerializeField]
    bool _isStorage = true;

    [SerializeField]
    private List<Item> _items_inStorage;

    public IEnumerable<Item> Items => _items_inStorage;

    public List<Item> GetList()
    {
        return _items_inStorage;
    }

    public void AddItemToStorage(Item item)
    {
        _items_inStorage.Add(item);
        Debug.Log("Add new Item to Storage");
    }

    private void OnDisable()
    {
        if (_isStorage)
            _items_inStorage.Clear();
    }
}
