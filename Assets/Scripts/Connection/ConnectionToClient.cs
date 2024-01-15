using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
using System.Threading;
[AosSdk.Core.Utils.AosObject(name: "�������")]
public class ConnectionToClient : AosObjectBase
{
    [SerializeField] private WebSocketWrapper _wrapper;
    [AosEvent(name: "����� � �����������")]
    public event AosEventHandlerWithAttribute OnReadyToAction;
    public UnityAction ConnectionReadyEvent;
    private string _readyText = "Ready to Action";

    private void Start() => _wrapper.OnClientConnected += OnReadyToConnect;
    public void OnReadyToConnect()
    {
        Thread.Sleep(2000);
        OnReadyToAction.Invoke(_readyText);
        ConnectionReadyEvent?.Invoke();
    }
}
