using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosSdk.Core.Utils.AosObject(name: "AosObject")]
public class SceneAosObject : AosObjectBase
{
    [AosEvent(name: "OnClickObject")]
    public event AosEventHandlerWithAttribute OnClickObject;
    [SerializeField] private bool _button;
    [SerializeField] private BackButtonObject _backButton;

    public void InvokeOnClick()
    {
        if (_backButton != null)
        {
            BackButtonsActivator.Instance.SetBackButtonObject(_backButton);
        }
            
            OnClickObject?.Invoke(ObjectId);
    }

    public void ActionWithObject(string actionName)
    {
        OnClickObject?.Invoke(actionName);
    }
}
