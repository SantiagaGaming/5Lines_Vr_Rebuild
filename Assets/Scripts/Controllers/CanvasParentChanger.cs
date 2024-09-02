using AosSdk.Core.PlayerModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasParentChanger : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private CursorManager _cursorManager;
    [SerializeField] private MouseRayCastHandler _mouseRayCastHandler;
    [SerializeField] private BaseActionObject _backActionObject;
    private Camera _camera;
    private bool activeBack = true;
    public void ChangeCameraParent(Camera camera)
    {

        activeBack = true;
        //  _mainCamera.enabled = false;
        _camera = camera;
        _mouseRayCastHandler.SetActionCamera(_camera);
     //   _camera.enabled = true;
        StartCoroutine(SwitchCameraMove(_mainCamera,_camera,1f,activeBack));
        _canvas.transform.SetParent(_camera.transform);
        _cursorManager.EnableCursor(true);
        SceneObjectsHolder.Instance.CurrentState = PlayerState.Look;
       // _backActionObject.Enable();
        
    }
    public void RevertCamera()
    {
        activeBack= false;
        StartCoroutine(SwitchCameraMove(_camera, _mainCamera, 1f,activeBack));
        _mouseRayCastHandler.SetActionCamera(null);
      //  _camera.enabled = false;
        _camera = null;
       // _mainCamera.enabled = true;
        _canvas.transform.SetParent(_mainCamera.transform);
        _cursorManager.EnableCursor(false);
        SceneObjectsHolder.Instance.CurrentState = PlayerState.Walk;
       // _backActionObject.Disable();
    }
    public IEnumerator SwitchCameraMove(Camera currentCamera, Camera cameraTarget, float transitionDuration,bool active)
    {
        currentCamera.enabled= false;
        cameraTarget.enabled= true;

        Transform mainCameraTransform = cameraTarget.transform;
        Vector3 startPosition = currentCamera.transform.position;
        Quaternion startRotation = currentCamera.transform.rotation;
        Vector3 endPosition = cameraTarget.transform.position;
        Quaternion endRotation = cameraTarget.transform.rotation;

        float elapsedTime = 0f;
        mainCameraTransform.rotation = startRotation;
        mainCameraTransform.position = startPosition;

        while (elapsedTime < transitionDuration)
        {
            elapsedTime += Time.deltaTime;

            mainCameraTransform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / transitionDuration);
            mainCameraTransform.rotation = Quaternion.Lerp(startRotation, endRotation, elapsedTime / transitionDuration);

            yield return null;
        }
        if(active)
        _backActionObject.Enable();
        else _backActionObject.Disable();
    }
  
}
