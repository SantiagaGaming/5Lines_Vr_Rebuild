using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosSdk.Core.Utils.AosObject(name: "������ ������")]
public class Stone : AosObjectBase
{
    [SerializeField] private GameObject _stone;
    [SerializeField] private SoundPlayer _soundPlayer;
    private bool _canPlay = true;
    [AosAction(name: "������� ��������� ������� true - �������, false - ���������")]
    public void SetCondition(bool value)
    {
            _stone.SetActive(value);
        if (!value && _canPlay)
        {
            _canPlay = false;
            _soundPlayer.PlayStoneSound();
        }
    }
}
