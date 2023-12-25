using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseUIButton : MonoBehaviour
{
    protected Button Button;
    protected API API;
    protected virtual void Awake()
    {
        Button = GetComponent<Button>();
        if (Button != null)
            Button.onClick.AddListener(() => Click());
    }
    private void Start()
    {
        API = FindObjectOfType<API>();
    }

    protected virtual void Click()
    {
    }
    public virtual void EnableUIButton(bool value)
    {
        if(Button!=null)
        Button.enabled = value;
    }
}
