using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class StartWork : AbstractInfoClass
{
    [SerializeField]
    Button _start_work;

    [SerializeField]
    Animator animator;

    [SerializeField]
    float timetoWork = 2.0f;
    AddNewItemToStorage _item_to_storage;

    [Header("ItemsToCollect")]
    [SerializeField]
    ItemsList _items_to_mine;
    [Header("CountItems")]
    [SerializeField]
    int _count_items_to_mine;
    [SerializeField]
    int _item_chanse;

    ItemsList items_to_get;
   
    //[SerializeField] Item item_to_mine;
    //[SerializeField] int count_to_mine_per_tick;
    private void OnValidate()
    {
       
    }

    private void Start()
    {
        _item_to_storage = GameObject.FindWithTag("ItemsStorage").GetComponent<AddNewItemToStorage>();
        mainAlert = GameObject.Find("Canvas").GetComponent<MainAlerts>();
        _info_button.onClick.AddListener(OnInfo);
        _start_work.onClick.AddListener(Work);
        animator = this.gameObject.GetComponent<Animator>();
    }

    void Work()
    {
        if (animator.GetBool("Play") == false)
        {
            animator.speed = timetoWork;
            animator.SetBool("Play", true);
            StartCoroutine(SetState(timetoWork));
        }
    }

    void GetRewardFromWork()
    {
        
        RandomItems MyRandom = new RandomItems();

        
        items_to_get = MyRandom.GetRandomItems(_items_to_mine, _item_chanse);
        for (int i = 0; i < items_to_get.GetList().Count; i++)
        {
            _item_to_storage.AddObject(items_to_get.GetList()[i].name, items_to_get.GetList()[i].Description, items_to_get.GetList()[i], _count_items_to_mine);
        }
       


        //_item_to_storage.AddObject(item_to_mine.name, item_to_mine.Description, item_to_mine,count_to_mine_per_tick);     
    }

    IEnumerator SetState(float time)
    {
        
        yield return new WaitForSeconds(time);
        animator.SetBool("Play", false);
        //Debug.Log("1");
        //GetRewardFromWork();
        //Debug.Log("2");
    }

    public void AddMineItem(Item item, int count)
    {
        _items_to_mine.AddItemToStorage(item);
        _count_items_to_mine= count;
    }

    public override void OnInfo()
    {
        base.OnInfo();
    }
    public override void SetParams(string name, string desrc)
    {
        base.SetParams(name, desrc);
    }
}
