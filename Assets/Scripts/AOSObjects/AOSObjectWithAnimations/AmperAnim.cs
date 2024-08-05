using AosSdk.Core.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AosSdk.Core.Utils.AosObject(name: "�������� Amper")]

public class AmperAnim : AosObjectBase
{
    private Animator _anim;
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    [AosAction(name: "��������� �������� ��� ��������")]
    public void NoPerev()
    {

        _anim.SetTrigger("NoPerev");
    }
    [AosAction(name: "��������� �������� ���������� ��������")]
    public void NormPerev()
    {
        _anim.SetTrigger("NormPerev");
    }
    [AosAction(name: "��������� �������� �������")]
    public void FrictPerev()
    {
        _anim.SetTrigger("FrictPerev");
    }
    [AosAction(name: "��������� �������� �����")]
    public void StonePerev()
    {
        _anim.SetTrigger("StonePerev");
    }
}
