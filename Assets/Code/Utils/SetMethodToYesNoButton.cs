using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SetMethodToYesNoButton : MonoBehaviour
{
    [SerializeField]
    UnityAction _yesAction;
    [SerializeField]
    UnityAction _noAction;

    [SerializeField]
    Button _yesButton;
    [SerializeField]
    Button _noButton;

    public void SetAction(UnityAction yesAction, UnityAction noAction)
    {
        _yesAction = yesAction;
        _noAction = noAction;

        _yesButton.onClick.AddListener(_yesAction);
        _noButton.onClick.AddListener(_noAction);
        Debug.Log("YesNo methods successfully assigned");
    }
}
