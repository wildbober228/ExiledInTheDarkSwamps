using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    [SerializeField]
    Animator _animator;

    int state = 0;

    [SerializeField]
    GameObject _button_left;

    [SerializeField]
    GameObject _button_right;

    private void Start()
    {
        if(_animator == null)
        _animator = this.gameObject.GetComponent<Animator>();
    }

    public void SwitchToLeft()
    {
        StartCoroutine(EnableButtons());
        if (state == 0)//MiddleToLeft
        {
            StartCoroutine(SetState(1));
            _animator.SetInteger("UI_State", 1);        
        }
        if (state == 2)//RightToMiddle
        {
            StartCoroutine(SetState(0));
            _animator.SetInteger("UI_State", 4);
        }
    }
    public void SwitchToRight()
    {
        StartCoroutine(EnableButtons());
        if (state == 0)//MiddleToRight
        {
            StartCoroutine(SetState(2));
            _animator.SetInteger("UI_State", 2);
        }

        if (state == 1)//LeftToMiddle
        {  
            StartCoroutine(SetState(0));
            _animator.SetInteger("UI_State", 3);
        }
       
    }

    IEnumerator SetState(int st)
    {
        yield return new WaitForSeconds(0.2f);
        state = st;
    }

    IEnumerator EnableButtons()
    {
        _button_left.SetActive(false);
        _button_right.SetActive(false);
        yield return new WaitForSeconds(1.2f);

        if (state == 2)
        {
            _button_left.SetActive(true);
        }
        else if(state == 1)
        {
            _button_right.SetActive(true);
        }
        else
        {
            _button_left.SetActive(true);
            _button_right.SetActive(true);
        }
    }

}
