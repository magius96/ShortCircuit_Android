using Assets.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{

    public enum MainMenuButtonType
    {
        ClassicLevels,
        AdvancedLevels,
        InfiniteLevels,
        Instructions,
        Options,
        Credits,
        Quit
    }

    public void Start()
    {
        SetText();
    }

    private void OnValidate()
    {
        SetText();
    }

    public MainMenuButtonType ButtonType;

    public void MainMenuButtonPressed()
    {
        Debug.Log("Main Menu Button Pressed: " + ButtonType);
        Globals.PreviousScreen.Push("MainMenuScreen");
        switch (ButtonType)
        {
            case MainMenuButtonType.ClassicLevels:
                SceneManager.LoadScene("ClassicLevelSelectScreen");
                break;
            case MainMenuButtonType.AdvancedLevels:
                SceneManager.LoadScene("AdvancedLevelSelectScreen");
                break;
            case MainMenuButtonType.InfiniteLevels:
                SceneManager.LoadScene("InfiniteLevelSetupScreen");
                break;
            case MainMenuButtonType.Instructions:
                SceneManager.LoadScene("InstructionScreen");
                break;
            case MainMenuButtonType.Options:
                SceneManager.LoadScene("OptionsScreen");
                break;
            case MainMenuButtonType.Credits:
                SceneManager.LoadScene("CreditsScreen");
                break;
            case MainMenuButtonType.Quit:
                Application.Quit();
                break;
        }
    }

    public void SetText()
    {
        var ugui = GetComponentInChildren<TextMeshProUGUI>();
        if (ugui == null) return;
        switch (ButtonType)
        {
            case MainMenuButtonType.ClassicLevels:
                ugui.text = "Classic Levels";
                break;
            case MainMenuButtonType.AdvancedLevels:
                ugui.text = "Advanced Levels";
                break;
            case MainMenuButtonType.InfiniteLevels:
                ugui.text = "Infinite Levels";
                break;
            case MainMenuButtonType.Instructions:
                ugui.text = "Instructions";
                break;
            case MainMenuButtonType.Options:
                ugui.text = "Options";
                break;
            case MainMenuButtonType.Credits:
                ugui.text = "Credits";
                break;
            case MainMenuButtonType.Quit:
                ugui.text = "Quit";
                break;
        }
    }
}
