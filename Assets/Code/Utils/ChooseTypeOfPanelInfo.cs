using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseTypeOfPanelInfo : MonoBehaviour
{
    [SerializeField]
    GameObject _okeyObj;

    [SerializeField]
    GameObject _yesno;

    public enum TypeButton
    {
        Okey,
        YesNo
    }
    public TypeButton type;

    public void ChooseTypeButton(TypeButton _type)
    {
        type = _type;
        switch (type)
        {
            case TypeButton.Okey:
                _okeyObj.SetActive(true);
                break;

            case TypeButton.YesNo:
                _yesno.SetActive(true);
                break;
        }
    }
}
