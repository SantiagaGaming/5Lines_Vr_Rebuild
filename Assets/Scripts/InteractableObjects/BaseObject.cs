using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.PlayerModule.Pointer;
using UnityEngine;

public abstract class BaseObject : MonoBehaviour, IClickAble, IHoverAble
{
    public bool IsHoverable { get; set; } = true;
    public bool IsClickable { get; set; } = true;

    protected SceneAosObject SceneAOSObject;
    protected virtual void Awake() => SceneAOSObject = GetComponent<SceneAosObject>();

    public virtual void OnClicked(InteractHand interactHand)
    {
        InvokeAosEvent();
    }
    public void InvokeAosEvent()
    {
        if (SceneAOSObject != null)
        SceneAOSObject.InvokeOnClick();
    }
    public string GetAOSName()
    {
        return SceneAOSObject == null ? null : SceneAOSObject.ObjectId;
    }
    public virtual void OnHoverIn(InteractHand interactHand)
    {
    }
    public virtual void OnHoverOut(InteractHand interactHand)
    {
    }
    public virtual void EnableObject(bool value)
    {
    }
}