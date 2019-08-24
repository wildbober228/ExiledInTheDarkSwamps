using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StartWork : AbstractInfoClass
{
    [SerializeField]
    Button _start_work;

    [SerializeField]
    Animator animator;

    [SerializeField]
    float timetoWork = 2.0f;
    AddNewItemToStorage _item_to_storage;

    [SerializeField] Item item_to_mine;
    [SerializeField] int count_to_mine_per_tick;
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
        _item_to_storage.AddObject(item_to_mine.name, item_to_mine.Description, item_to_mine,count_to_mine_per_tick);     
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
        item_to_mine = item;
        count_to_mine_per_tick = count;
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
