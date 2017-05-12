using System;
using UnityEngine;
using System.Collections;
using Assets.Scripts;
using Assets.Scripts.Levels;

public class InfiniteLevelSetup : MonoBehaviour
{
    private bool _initialized = false;
    private bool _use3Phase = false;
    private float _gridsize = 5f;
    private float _minMoves = 2f;

    private GUIStyle _headerStyle;
    private GUIStyle _toggleStyle;
    private GUIStyle _leftLabelStyle;
    private GUIStyle _rightLabelStyle;
    private GUIStyle _sliderStyle;
    private GUIStyle _sliderButtonStyle;
    private GUIStyle _buttonStyle;

    public void Start()
    {
        Globals.Load();
    }

    public void Update()
    {
        if (!_initialized) Initialize();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.PlaySFX("ButtonClick");
            Globals.LoadPreviousScreen();
        }
    }

    private void Initialize()
    {
        _use3Phase = Globals.InfiniteLevelUses3Phase;
        _gridsize = Globals.InfiniteLevelGridSize;
        _minMoves = Globals.InfiniteLevelMoves;

        _headerStyle = new GUIStyle();
        _headerStyle.fontSize = 30;
        _headerStyle.fontStyle = FontStyle.Bold;
        _headerStyle.normal.textColor = new Color(1f, 1f, 0f);
        _headerStyle.alignment = TextAnchor.LowerCenter;

        _toggleStyle = new GUIStyle();
        _toggleStyle.normal.textColor = Color.white;
        _toggleStyle.fontSize = 20;
        _toggleStyle.alignment = TextAnchor.LowerLeft;
        _toggleStyle.normal.background = Globals.MakeColorTex(new Color(1, 1, 1, 0));

        _leftLabelStyle = new GUIStyle();
        _leftLabelStyle.fontSize = 20;
        _leftLabelStyle.normal.textColor = Color.white;
        _leftLabelStyle.alignment = TextAnchor.LowerLeft;

        _rightLabelStyle = new GUIStyle();
        _rightLabelStyle.fontSize = 20;
        _rightLabelStyle.normal.textColor = Color.white;
        _rightLabelStyle.alignment = TextAnchor.LowerRight;

        _sliderStyle = new GUIStyle();
        _sliderStyle.normal.background = Globals.MakeColorTex(Color.grey);
        _sliderStyle.margin = new RectOffset(10, 10, 10, 10);

        _sliderButtonStyle = new GUIStyle();
        _sliderButtonStyle.normal.background = Globals.MakeColorTex(Color.white);
        _sliderButtonStyle.padding = new RectOffset(10, 10, 10, 10);
        _sliderButtonStyle.margin = new RectOffset(5, 5, 5, 5);

        _buttonStyle = new GUIStyle();
        _buttonStyle.normal.background = Globals.MakeColorTex(Color.blue);
        _buttonStyle.fontSize = 22;
        _buttonStyle.normal.textColor = Color.white;
        _buttonStyle.fontStyle = FontStyle.Bold;
        _buttonStyle.alignment = TextAnchor.MiddleCenter;
    }

    public void OnGUI()
    {
        float rx = Screen.width / Globals.NativeWidth;
        float ry = Screen.height / Globals.NativeHeight;
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(rx, ry, 1));

        GUI.Label(new Rect(0, 0, 320, 40), "Infinite Levels", _headerStyle);

        if (GUI.Button(new Rect(10, 100, 300, 20), "Use 3 phase lights", _toggleStyle))
        {
            SoundManager.PlaySFX("ButtonClick");
            _use3Phase = !_use3Phase;
            Globals.InfiniteLevelUses3Phase = _use3Phase;
        }
        GUI.Label(new Rect(270, 100, 40, 20), _use3Phase ? "Yes" : "No", _rightLabelStyle);

        GUI.Label(new Rect(10, 170, 200, 20), "Grid Size", _leftLabelStyle);
        GUI.Label(new Rect(250, 170, 50, 20), _gridsize.ToString(), _rightLabelStyle);
        _gridsize = GUI.HorizontalSlider(new Rect(10, 200, 300, 20), _gridsize, 3f, 10f, _sliderStyle, _sliderButtonStyle);
        Globals.InfiniteLevelGridSize = (int)_gridsize;

        GUI.Label(new Rect(10, 260, 200, 20), "Minimum Moves", _leftLabelStyle);
        GUI.Label(new Rect(250, 260, 50, 20), _minMoves.ToString(), _rightLabelStyle);
        _minMoves = GUI.HorizontalSlider(new Rect(10, 290, 300, 20), _minMoves, 1f, (_gridsize * _gridsize) / 2f, _sliderStyle, _sliderButtonStyle);
        Globals.InfiniteLevelMoves = (int)_minMoves;

        if (GUI.Button(new Rect(10, 430, 320, 40), "Start", _buttonStyle))
        {
            SoundManager.PlaySFX("ButtonClick");
            Globals.PreviousScreen.Push("InfiniteLevelSetupScreen");
            Globals.CurrentLevel = new InfiniteLevel();
            Application.LoadLevel("GameScreen");
        }
    }

    private GUIStyle SetupButtonStyle(Color buttonColor)
    {
        var style = new GUIStyle();
        style.normal.background = Globals.MakeColorTex(buttonColor);
        style.fontSize = 22;
        style.alignment = TextAnchor.MiddleCenter;
        style.fontStyle = FontStyle.Bold;
        style.normal.textColor = Color.gray;
        return style;
    }
}
