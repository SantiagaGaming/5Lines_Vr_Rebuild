using AosSdk.Core.Utils;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[AosSdk.Core.Utils.AosObject(name: "��������� �����")]

public class StartScreen : AosObjectBase
{
    [SerializeField] private TextMeshProUGUI _commentText;
    public void SetStartScreen(string value)
    {
        _commentText.text = value;
    }
}
