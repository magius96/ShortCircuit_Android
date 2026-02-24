using System;
using UnityEngine;
using System.Collections;
using Assets.Scripts;
using Assets.Scripts.Levels;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class InfiniteLevelSetup : MonoBehaviour
{
    public Toggle ThreePhaseToggle;
    public Slider GridSizeSlider;
    public Slider MinMovesSlider;
    public TextMeshProUGUI GridSizeLabel;
    public TextMeshProUGUI MinMovesLabel;

    public void Start()
    {
        Globals.Load();
        Initialize();
    }

    public void Update()
    {
        //if (!_initialized) Initialize();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.PlaySFX("ButtonClick");
            Globals.LoadPreviousScreen();
        }
    }

    private void Initialize()
    {
        ThreePhaseToggle.isOn = Globals.InfiniteLevelUses3Phase;
        GridSizeSlider.value = Globals.InfiniteLevelGridSize;
        MinMovesSlider.value = Globals.InfiniteLevelMoves;
        GridSizeLabel.text = Globals.InfiniteLevelGridSize.ToString();
        MinMovesLabel.text = Globals.InfiniteLevelMoves.ToString();
    }

    public void ThreePhaseToggled()
    {
        SoundManager.PlaySFX("ButtonClick");
        Globals.InfiniteLevelUses3Phase = ThreePhaseToggle.isOn;
    }

    public void GridSizeChanged()
    {
        Globals.InfiniteLevelGridSize = (int)GridSizeSlider.value;
        GridSizeLabel.text = Globals.InfiniteLevelGridSize.ToString();
        MinMovesSlider.minValue = 1;
        MinMovesSlider.maxValue = (int)((Globals.InfiniteLevelGridSize * Globals.InfiniteLevelGridSize) / 2f);
        if (MinMovesSlider.value > MinMovesSlider.maxValue) MinMovesSlider.value = MinMovesSlider.maxValue;
    }

    public void MinMovesChanged()
    {
        Globals.InfiniteLevelMoves = (int)MinMovesSlider.value;
        MinMovesLabel.text = Globals.InfiniteLevelMoves.ToString();
    }

    public void StartButtonClicked()
    {
        SoundManager.PlaySFX("ButtonClick");
        Globals.PreviousScreen.Push("InfiniteLevelSetupScreen");
        Globals.CurrentLevel = new InfiniteLevel();
        SceneManager.LoadScene("GameScreen");
    }

    public void BackButtonClicked()
    {
        SoundManager.PlaySFX("ButtonClick");
        Globals.LoadPreviousScreen();
    }
}
