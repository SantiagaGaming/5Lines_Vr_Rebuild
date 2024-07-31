using System.Collections.Generic;
using UnityEngine;
public class Diet : MonoBehaviour
{

    [SerializeField] private GameObject _prefubRadioButton;
    [SerializeField] private Transform _parent;
    public List<RadioButtons> _radioButtonsList;
    public List<GameObject> _prefabsRadio;
    

    public void EnablePlusOrMinus(string buttonName, string text)
    {
        var prefub = Instantiate(_prefubRadioButton, _parent);
        var radioButton = prefub.GetComponentInChildren<RadioButtons>();
        radioButton.gameObject.name = buttonName;
        radioButton.SetButtonText(text);
        _radioButtonsList.Add(radioButton);
        _prefabsRadio.Add(prefub);
    }
    public void DestroyRadioButton()
    {
        foreach (var reactionButton in _radioButtonsList)
        {
            if (reactionButton != null)
                Destroy(reactionButton.gameObject);
        }
        foreach (var prefab in _prefabsRadio)
        {
            if (prefab != null)
                Destroy(prefab);
        }
        _radioButtonsList = new List<RadioButtons>();
        _prefabsRadio = new List<GameObject>();

    }
}
