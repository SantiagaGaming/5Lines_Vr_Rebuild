using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseStartScreenView : MonoBehaviour
{
    [SerializeField] protected ModeController ModeController;
    [SerializeField] protected GameObject NextButtonGameObject;
    [SerializeField] protected GameObject LoadImage;
    [SerializeField] protected GameObject CatoLogoImage;
    [SerializeField] protected GameObject LineImage;
    [SerializeField] protected GameObject GuideButton;
    [SerializeField] protected NextUIButton _nextUIButton;
    [Space]
    [SerializeField] protected TextMeshProUGUI HeaderText;
    [SerializeField] protected TextMeshProUGUI CommentText; 
    [SerializeField] protected TextMeshProUGUI HeaderFaultText;
    [SerializeField] protected TextMeshProUGUI CommentFaultText;

  

    

  
    private void Start()
    {
        _nextUIButton.NextButtonPressedEvent += OnHideStartScreen;
        Cursor.visible = true;
    }
    public virtual void SetStartScreenText(string headerText, string commentText, string headerFaultText, string commentFaultText)
    {
        LoadImage.SetActive(false);
        CatoLogoImage.SetActive(true);
        GuideButton.SetActive(true);
        NextButtonGameObject.SetActive(true);       

        HeaderText.text = headerText;
        CommentText.text = commentText;
        HeaderFaultText.text = headerFaultText;
        CommentFaultText.text = commentFaultText;
      
    }
    protected virtual void OnHideStartScreen(string text)
    {
        if (text == "start")
        {
            LineImage.SetActive(true);
            DisableStartScreen();
            ModeController.CurrentInteractScreen.EnableAllHelperObjects(true);
            ModeController.CurrentInteractScreen.EnableLocationObject(true);
            ModeController.CurrentInteractScreen.EnableTimerObject(true);
            ModeController.CurrentMenuController.CanTeleport = true;

        }
    }
    protected abstract void DisableStartScreen();

}
