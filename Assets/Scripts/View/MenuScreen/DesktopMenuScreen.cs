using TMPro;
using UnityEngine;

public class DesktopMenuScreen : BaseMenuScreen
{
    [SerializeField] private TextMeshProUGUI _infoHeaderText;
    [SerializeField] private TextMeshProUGUI _infoText;
    [SerializeField] private TextMeshProUGUI _exitSureText;
    [SerializeField] private TextMeshProUGUI _exitText;
    [SerializeField] private TextMeshProUGUI _warnText;
    [SerializeField] private TextMeshProUGUI _headerText;
    [SerializeField] private TextMeshProUGUI _evalText;
    [SerializeField] private TextMeshProUGUI _commentText;
    [Space]
    [SerializeField] private DesktopCanvasHolder _desktopCanvasHolder;
    [SerializeField] private GameObject[] _allScreens;
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _exitButton;
    [SerializeField] private GameObject _backButton;

    public override void SetMenuText(string headText, string commentText, string exitSureText)
    {
        _infoHeaderText.text = HtmlToText.Instance.HTMLToTextReplace(headText);
        _infoText.text = HtmlToText.Instance.HTMLToTextReplace(commentText);
        _exitSureText.text = HtmlToText.Instance.HTMLToTextReplace(exitSureText);
    }
    public override void SetExitText(string exitText, string warnText)
    {
        _exitText.text = HtmlToText.Instance.HTMLToTextReplace(exitText);
        _warnText.text = HtmlToText.Instance.HTMLToTextReplace(warnText);
    }
    public override void ShowMessageScreen(string headText, string commentText)
    {
        _desktopCanvasHolder.DisableAllCanvases();
        _desktopCanvasHolder.EnableCanvasByState(CanvasState.Last);
        ShowMessageScreen();
        SetText(headText, commentText);
    }
    public override void ShowLastScreen(string headText, string commentText, string evalText)
    {
        _desktopCanvasHolder.DisableAllCanvases();
        _desktopCanvasHolder.EnableCanvasByState(CanvasState.MainMenu);
        _desktopCanvasHolder.EnableCanvasByState(CanvasState.Last);
        _backButton.SetActive(false);
        _exitButton.SetActive(true);
        SetText(headText, commentText, evalText);
    }
    private void SetText(string headText, string commentText)
    {
        _headerText.text = headText;
        _commentText.text = commentText;
    }
    private void SetText(string headText, string commentText, string evalText)
    {
        _headerText.text = headText;
        _commentText.text = commentText;
        _evalText.text = evalText;
    }
    private void ShowMessageScreen()
    {
        _desktopCanvasHolder.EnableCanvasByState(CanvasState.Last);
    }

    public override void ShowMenuScreen(bool active)
    {
        _desktopCanvasHolder.DisableAllCanvases();
        _menu.SetActive(active);
        if (active)
        {
            _desktopCanvasHolder.EnableCanvasByState(CanvasState.MainMenu);
            _desktopCanvasHolder.EnableCanvasByState(CanvasState.Menu);
        }
    }
}
