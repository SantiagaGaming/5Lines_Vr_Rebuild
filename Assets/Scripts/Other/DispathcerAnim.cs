using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispathcerAnim : MonoBehaviour
{

    private Animator _anim;
    private void OnEnable()
    {
        StrelkaAOS.StrelkaChangedEvent += OnPlayStrelkaAnim;
    }
    private void OnDisable()
    {
        StrelkaAOS.StrelkaChangedEvent -= OnPlayStrelkaAnim;
    }
    private void Start()
    {
        _anim= GetComponent<Animator>();
    }
    private void OnPlayStrelkaAnim(string value)
    {
        if(value == "1")
        {
            _anim.SetTrigger("1");
        }
        if (value == "2")
        {
            _anim.SetTrigger("2");
        }
        if (value == "3")
        {
            _anim.SetTrigger("3");
        }
        if (value == "4")
        {
            _anim.SetTrigger("4");
        }
    }
}
