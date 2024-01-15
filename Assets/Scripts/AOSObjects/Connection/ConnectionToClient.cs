using AosSdk.Core.Utils;
using UnityEngine;
using System.Threading;
using System;
[AosSdk.Core.Utils.AosObject(name: "�������")]
public class ConnectionToClient : AosObjectBase
{
    [SerializeField] private WebSocketWrapper _wrapper;
    [AosEvent(name: "����� � �����������")]
    public event AosEventHandlerWithAttribute OnReadyToAction;
    public Action ConnectionReadyEvent;

    private const string READY_TO_ACTION_TEXT = "Ready to Action";

    private void Start() => _wrapper.OnClientConnected += OnReadyToConnect;
    public void OnReadyToConnect()
    {
        Thread.Sleep(2000);
        OnReadyToAction.Invoke(READY_TO_ACTION_TEXT);
        ConnectionReadyEvent?.Invoke();
    }
}
