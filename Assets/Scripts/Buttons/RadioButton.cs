using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.PlayerModule.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class RadioButton : BaseButton
{
    [SerializeField] private Diet _diet;
    [SerializeField] private BackButtonObject _backButton;
    [SerializeField] protected Transform _dietPosition;
    private bool _radio = false;
    private void OnEnable()
    {
        _backButton.BackButtonClickEvent += OnBackClicked;
    }
    private void OnDisable()
    {
        _backButton.BackButtonClickEvent -= OnBackClicked;
    }
    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        DietEnabler();
    }
    private void DietEnabler()
    {
        if (!_radio) _radio = true;
        else _radio = false;
        _diet.EnableDiet(_radio, _dietPosition);
    }
    private void OnBackClicked()
    {
        if(_radio)
        {
            _radio = false;
            _diet.EnableDiet(_radio, _dietPosition);

        }
    }
}
