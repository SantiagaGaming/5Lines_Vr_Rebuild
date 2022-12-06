using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
public class LocationController : MonoBehaviour
{
    [SerializeField] private API _api;
    [SerializeField] private LocationText _locationText;
    [SerializeField] private ConnectionChecker _connectionChecker;
    private string _currentLocation = "field";
    public void SetLocationtext(string text)
    {
        _locationText.SetLocationText(text);
    }
    public void ConnectionEstablished()
    {
        _api.ConnectionEstablished(_currentLocation);
    }
    public void SetLocation(string location)
    {
        _currentLocation = location;
        StreetCollidersActivator.Instance.ActivateColliders(location);
    }
    public string GetLocationName() => _currentLocation;
}
