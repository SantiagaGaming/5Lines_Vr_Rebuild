using AosSdk.Core.Utils;
using UnityEngine;

[AosSdk.Core.Utils.AosObject(name: "������� ��������")]
public class LampEnabler : AosObjectBase
{
    [SerializeField] private Lamp _lamp;
    [AosAction(name: "������� ���� ��������: �������")]
    public void SetLampColor()
    {
        _lamp.ChangeColor();
    }

    [AosAction(name: "������� ���� ��������: ������")]
    public void ResetLampColor()
    {
        _lamp.ResetColor();
    }
}
