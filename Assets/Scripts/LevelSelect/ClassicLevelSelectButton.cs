using Assets.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClassicLevelSelectButton : MonoBehaviour
{
    public Button LevelSelectButton;
    public TextMeshProUGUI LevelSelectButtonText;
    public ClassicLevels Level;

    private GameLevel _gameLevel;

    public void Start()
    {
        SetButton();
    }

    public void OnValidate()
    {
        SetButton();
    }

    private void SetButton()
    {
        _gameLevel = LevelFactory.GetClassicLevel(Level);
        LevelSelectButtonText.text = _gameLevel.Name;
        SetColor();
    }

    private void SetColor()
    {
        if (PlayerPrefs.HasKey(_gameLevel.Id))
        {
            var moves = PlayerPrefs.GetInt(_gameLevel.Id);
            if (moves <= _gameLevel.Par)
            {
                LevelSelectButton.image.color = Color.green;
            }
            else
            {
                LevelSelectButton.image.color = Color.yellow;
            }
        }
        else
        {
            LevelSelectButton.image.color = Color.blue;
        }
    }

    public void ButtonClicked()
    {
        SoundManager.PlaySFX("ButtonClick");
        Globals.PreviousScreen.Push("ClassicLevelSelectScreen");
        Globals.CurrentLevel = _gameLevel;
        SceneManager.LoadScene("GameScreen");
    }
}
