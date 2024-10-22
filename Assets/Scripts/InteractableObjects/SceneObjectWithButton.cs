using AosSdk.Core.PlayerModule.Pointer;
using System;
using UnityEngine;

public class SceneObjectWithButton : SceneObject
{
    public Action<Transform> SetButtonsTransformEvent;
    [SerializeField] private Transform _buttonsPos;
    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        SceneObjectsHolder.Instance.ModeController.BaseReactionButtonsHandler.HideAllReactions();
        SetButtonsTransformEvent?.Invoke(_buttonsPos);
    }
}
