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

    private void Start()
    {
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

    IEnumerator SetState(float time)
    {
        yield return new WaitForSeconds(time);
        animator.SetBool("Play", false);
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
