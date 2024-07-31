using AosSdk.Core.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioButtons : BaseUIButton
{
    [SerializeField] private Text _text;
    protected override void Click()
    {
        var radioButtonObject = new JsonAosObject();
        radioButtonObject.castedToStringAttribute = gameObject.name;
        radioButtonObject.objectId = gameObject.name;
        WebSocketWrapper.Instance.DoSendMessage(radioButtonObject);
        Debug.Log("Click");
    }
    public void SetButtonText(string text)
    {
        _text.text = text;
    }
}
