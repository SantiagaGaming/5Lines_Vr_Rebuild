using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;


[AosSdk.Core.Utils.AosObject(name: "�������� � ���")]
public class LeverArm : AosObjectBase
{
    [SerializeField] private LeverarmDSP _leverarm;


    [AosAction(name: "������� ��������� �������� 0-���� 1 -�����, ��� ���������  - ��������")]
    public void SetRotationSide(int direction)
    {
        _leverarm.Rotate(direction);
    }


}
