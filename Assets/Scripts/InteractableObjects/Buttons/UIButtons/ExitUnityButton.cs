using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitUnityButton : BaseUIButton

{
    protected override void Click()
    {
        Application.Quit();
    }
}
