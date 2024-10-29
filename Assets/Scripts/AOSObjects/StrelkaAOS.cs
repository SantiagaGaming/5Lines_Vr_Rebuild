using AosSdk.Core.Utils;
using System;
using UnityEngine;

[AosSdk.Core.Utils.AosObject(name: "�������")]

public class StrelkaAOS : AosObjectBase
{
    private bool _condition;
    public static Action<string> StrelkaChangedEvent;

    [AosAction("������ ��������� ����� true +, false -")]
    public void SetStrelkaPosition([AosParameter("����������� ��������")] bool position)
    {
        SetCondition(position);
    }
    [AosEvent(name: "������� �������� ������� � ����")]
    public event AosEventHandler OnSwitchStrelkaPlus;
    [AosEvent(name: "������� �������� ������� � �����")]
    public event AosEventHandler OnSwitchStrelkaMinus;
    [AosEvent(name: "�� ����� � �����")]
    public event AosEventHandler FromPlusToMinus;
    [AosEvent(name: "�� ������ � ����")]
    public event AosEventHandler FromMinusToPlus;
    public void TrySwitchStrelkaPlus()
    {
        OnSwitchStrelkaPlus?.Invoke();
    }
    public void TrySwitchStrelkaMinus()
    {
        OnSwitchStrelkaMinus?.Invoke();
    }
    public void StrelkaFromPlusTominus()
    {
        FromPlusToMinus?.Invoke();
    }
    public void StrelkaFromMinusToPlus()
    {
        FromMinusToPlus?.Invoke();
    }
    public void SetCondition(bool value)
    {
        if (_condition && !value)
        {
            StrelkaFromPlusTominus();
        }
        else if (!_condition && value)
        {
            StrelkaFromMinusToPlus();
        }
        _condition = value;
    }
}
