using UnityEngine;
public class DesktopMenuController : BaseMenuController
{
    [SerializeField] private CameraFlash _cameraFlash;
    [SerializeField] private CursorManager _cursorManager;

    public override void TeleportToMenu()
    {
        base.TeleportToMenu();
        _cameraFlash.CameraFlashStart();
        _cursorManager.EnableCursor(true);
        if(SceneObjectsHolder.Instance.CurrentState == PlayerState.Look)
            SceneObjectsHolder.Instance.ModeController.CurrentInteractScreen.EnableBackButton(false);
    }
    public override void TeleportToGame()
    {
        base.TeleportToGame();

        if(SceneObjectsHolder.Instance.CurrentState == PlayerState.Walk)
        _cursorManager.EnableCursor(false);
        else
            SceneObjectsHolder.Instance.ModeController.CurrentInteractScreen.EnableBackButton(true);
        _cameraFlash.CameraFlashStart();
    }
    public override void TeleportByGameTimer()
    {
        base.TeleportByGameTimer();
        _cursorManager.EnableCursor(true);
        _cameraFlash.CameraFlashStart();
    }
}
