using AosSdk.Core.Utils;
using UnityEngine;
using System.Threading;
using System;
using Cysharp.Threading.Tasks;
[AosSdk.Core.Utils.AosObject(name: "Коннект")]
public class ConnectionToClient : AosObjectBase
{
    [SerializeField] private WebSocketWrapper _wrapper;
    [AosEvent(name: "Готов к подключению")]
    public event AosEventHandlerWithAttribute OnReadyToAction;
    public Action ConnectionReadyEvent;

    private const string READY_TO_ACTION_TEXT = "Ready to Action";

    private void Start() => _wrapper.OnClientConnected += OnReadyToConnect;
    public async void OnReadyToConnect(IAsyncResult async)
    {
        await TryConnection(async);
    }
    private async UniTask TryConnection(IAsyncResult async)
    {
        await UniTask.WaitUntil(() => async.IsCompleted);
        OnReadyToAction.Invoke(READY_TO_ACTION_TEXT);
        ConnectionReadyEvent?.Invoke();
        Debug.Log("Connection");
    }

}
