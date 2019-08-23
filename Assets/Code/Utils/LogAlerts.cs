using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LogAlerts : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI[] _logsUI;

    public void NewLog(string text)
    {
        _logsUI[2].text = _logsUI[1].text;
        _logsUI[1].text = _logsUI[0].text;
        _logsUI[0].text = text;
    }
}
