using AosSdk.Core.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OKCAnimation : SceneAosObject
{
    private Animator _anim;

    [AosAction(name: "�������� AB")]
    public void PlayAB()
    {
        _anim = GetComponent<Animator>();
        _anim.SetTrigger("AB");
    }
    [AosAction(name: "�������� VG")]
    public void PlayVG()
    {
        _anim = GetComponent<Animator>();
        _anim.SetTrigger("VG");
    }
    [AosAction(name: "�������� GA")]
    public void PlayGA()
    {
        _anim = GetComponent<Animator>();
        _anim.SetTrigger("GA");
    }
    [AosAction(name: "�������� BV")]
    public void PlayBV()
    {
        _anim = GetComponent<Animator>();
        _anim.SetTrigger("BV");
    }
    public void PlayVB()
    {
        _anim = GetComponent<Animator>();
        _anim.SetTrigger("VB");
    }
    public void PlayBA()
    {
        _anim = GetComponent<Animator>();
        _anim.SetTrigger("BA");
    }
}
