using AosSdk.Core.PlayerModule;
using System;
using UnityEngine;
public enum SceneActionState
{
    None,
    Radio,
    Scheme,
    Measure,
    Back
}

public class BaseActionObject : MonoBehaviour
{
    protected bool CanActivate { get; set; } = false;
    public SceneActionState SceneActionState => CurrentState;
    [SerializeField] protected SceneActionState CurrentState;
    [SerializeField] protected BaseActionButton BaseActionButton;
    [SerializeField] protected UIButtonWithColorChanger BaseUIButton;
    [SerializeField] private CursorManager _cursorManager;
    protected virtual void Start()
    {
        BaseActionButton.ActionButtonEvent += Activate;
        BaseUIButton.ClickButtonEvent += Activate;
        if (CurrentState == SceneActionState.None)
            CanActivate = true;
    }
    public void Enable()
    {
        CanActivate = true;
        BaseUIButton.BaseUIColorChanger.CanChangeState = true;
        BaseUIButton.BaseUIColorChanger.ActivateState();
        BaseUIButton.EnableUIButton(true);
    }
    public virtual void Activate()
    {
        if (!CanActivate)
            return;
        if(CurrentState != SceneActionState.Radio) // срабатывает левая анимация 
        {
            SceneObjectsHolder.Instance.ActionButtonsHolder.InVokeOnClick(CurrentState);
        }    
        BaseUIButton.BaseUIColorChanger.EnabledState();
        BaseUIButton.BaseUIColorChanger.CanChangeState = false;
        if (SceneObjectsHolder.Instance.GetPlayerState())
        {
            if (_cursorManager != null)
            {
                _cursorManager.EnableCursor(true);
                var playerInstance = Player.Instance;
                playerInstance.CursorLockMode = CursorLockMode.Locked;
            }

        }
    }
    public virtual void Deactivate()
    {
        BaseUIButton.BaseUIColorChanger.CanChangeState = true;
        BaseUIButton.BaseUIColorChanger.ActivateState();
        if (SceneObjectsHolder.Instance.GetPlayerState())
        {
            if (_cursorManager != null)
            {
                _cursorManager.EnableCursor(false);
                var playerInstance = Player.Instance;
                playerInstance.CursorLockMode = CursorLockMode.None;
            }

        }
    }
    public virtual void Disable()
    {
        Deactivate();
        CanActivate = false;
        BaseUIButton.BaseUIColorChanger.DeactivateState();
        BaseUIButton.EnableUIButton(false);
        BaseUIButton.BaseUIColorChanger.CanChangeState = false;
    }
}
