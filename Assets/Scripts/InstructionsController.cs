using UnityEngine;
using Assets.Scripts;
using TMPro;
using UnityEngine.UI;

public class InstructionsController : MonoBehaviour 
{
    public TextMeshProUGUI DisplayText;
    public Button OverviewButton;
    public Button ClassicButton;
    public Button AdvancedButton;
    public Button ScoringButton;

    private TabState _state = TabState.Overview;

    private string _overviewText = "Short Circuit is played on a grid of lights. To play the game, you turn the lights on or off by clicking on them. " +
        "When you click on a light, the other lights near it horizontally, or vertically, will also change their state.  The objective is to turn all the lights off.";
    private string _classicText = "The classic levels use only two-phase lights.  In Short Circuit these two phase lights are all blue.  When you toggle a two phase " +
        "light, it will cycle between on and off.  Two phase lights are light blue for on, and dark blue for off.";
    private string _advancedText = "The advanced levels introduce 3 phase lights.  Three phase lights operate similiar to the way a stop light operates, but are only off when " +
        "they are red.  When you click a three phase light, green will become yellow, yellow will become red, and red will become green.  Advanced levels use both two and three phase lights.";
    private string _scoringText = "Scoring in Short Circuit is the same as in golf. Each level has a par, the minimum number of moves needed to complete the level.  If you complete a level " +
        "with more moves than par, then the level will be shown as yellow on the level select screen. If you beat the level at or below par, it will be green on the level select screen.";

    private Color _selectedColor = new Color(0f, 0f, 1f);
    private Color _unselectedColor = new Color(0f, 0f, 0.5f);

    private void Start()
    {
        DoUpdates();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.PlaySFX("ButtonClick");
            Globals.LoadPreviousScreen();
        }
    }

    private void DoUpdates()
    {
        UpdateDisplayText();
        UpdateButtonColors();
    }

    private void UpdateButtonColors()
    {
        OverviewButton.GetComponent<Image>().color = _state == TabState.Overview ? _selectedColor : _unselectedColor;
        ClassicButton.GetComponent<Image>().color = _state == TabState.Classic ? _selectedColor : _unselectedColor;
        AdvancedButton.GetComponent<Image>().color = _state == TabState.Advanced ? _selectedColor : _unselectedColor;
        ScoringButton.GetComponent<Image>().color = _state == TabState.Scoring ? _selectedColor : _unselectedColor;
    }

    private void UpdateDisplayText()
    {
        switch (_state)
        {
            case TabState.Overview:
                DisplayText.text = _overviewText; break;
            case TabState.Classic:
                DisplayText.text = _classicText; break;
            case TabState.Advanced:
                DisplayText.text = _advancedText; break;
            case TabState.Scoring:
                DisplayText.text = _scoringText; break;
        }
    }

    public void OverviewButtonClicked()
    {
        SoundManager.PlaySFX("LightButtonClick");
        _state = TabState.Overview;
        DoUpdates();
    }

    public void ClassicButtonClicked()
    {
        SoundManager.PlaySFX("LightButtonClick");
        _state = TabState.Classic;
        DoUpdates();
    }

    public void AdvancedButtonClicked()
    {
        SoundManager.PlaySFX("LightButtonClick");
        _state = TabState.Advanced;
        DoUpdates();
    }

    public void ScoringButtonClicked()
    {
        SoundManager.PlaySFX("LightButtonClick");
        _state = TabState.Scoring;
        DoUpdates();
    }

    public void BackButtonClicked()
    {
        SoundManager.PlaySFX("ButtonClick");
        Globals.LoadPreviousScreen();
    }

    enum TabState
    {
        Overview,
        Classic,
        Advanced,
        Scoring
    }
}
