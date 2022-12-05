using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosSdk.Core.Utils.AosObject(name: "������ ������")]
public class Stone : AosObjectBase
{
    [SerializeField] private GameObject _stone;

    [AosAction(name: "������� ��������� ������� true - �������, false - ���������")]
    public void SetCondition(bool value)
    {
        _stone.SetActive(value);
    }

}
