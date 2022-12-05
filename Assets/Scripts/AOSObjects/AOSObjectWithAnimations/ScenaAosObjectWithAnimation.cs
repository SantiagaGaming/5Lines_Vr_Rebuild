using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

public class ScenaAosObjectWithAnimation : SceneAosObject
{
    private IAnimationObject _animationObject;

    [AosAction(name: "��������� �������� ��������")]
    public void PlayOpenAnimation()
    {
        _animationObject = GetComponent<IAnimationObject>();
        if(_animationObject!=null)
        _animationObject.OpenAnimation();
    }

    [AosAction(name: "��������� �������� ��������")]
    public void PlayCloseAnimation()
    {
        _animationObject = GetComponent<IAnimationObject>();
        if (_animationObject != null)
            _animationObject.CloseAnimation();
    }

}
