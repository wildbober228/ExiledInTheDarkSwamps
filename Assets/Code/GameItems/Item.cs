using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Items/Item")]
public class Item : ScriptableObject
{
    public ChooseItem Chooseitem;

    [SerializeField]
    private string _name;
    [SerializeField]
    private int _cost;
    [SerializeField]
    private int _id_item;
    [SerializeField]
    private int _count;

    public string Name => _name;
    public int Cost => _cost;
    public int Id => _id_item;
    public int Count => _count;

    public void AddCountItem(int count)
    {
        _count += count;
    }

    public enum TypeItem
    {
        food,
        craftable,
        armor
    }
    public TypeItem typeItem;
}
