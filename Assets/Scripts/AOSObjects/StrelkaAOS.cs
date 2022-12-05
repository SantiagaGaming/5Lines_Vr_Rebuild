using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosSdk.Core.Utils.AosObject(name: "�������")]

public class StrelkaAOS : AosObjectBase
    
{
    [SerializeField] private Strelka _strelka;

    [AosAction("������ ��������� ����� true +, false -")]
    public void SetStrelkaPosition([AosParameter("����������� ��������")] bool position)
    {
        _strelka.SetCondition(position);
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
}
