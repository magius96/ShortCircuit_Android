using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;

public class ButtonManager : MonoBehaviour 
{
    public AudioClip UiClickSound;
    public AudioClip ClickSound;
    public AudioClip DingSound;

    private int[,] _grid;
    private GUIStyle _greenStyle;
    private GUIStyle _redStyle;
    private GUIStyle _yellowStyle;
    private GUIStyle _onStyle;
    private GUIStyle _offStyle;
    private GUIStyle _completionShadowStyle;
    private GUIStyle _completionParTextStyle;
    private GUIStyle _buttonStyle;
    private GUIStyle _leftUiTextStyle;
    private GUIStyle _rightUiTextStyle;
    private bool _initialized = false;
    private int Moves = 0;
    private bool _dinged = false;
    private AudioSource _audioSource;

    void Start()
    {
        Globals.Load();
    }

    void SetupLevel()
    {
        if (Globals.CurrentLevel.Id == "TestLevel")
        {
            var target = Globals.PreviousScreen.Pop();
            if (string.IsNullOrEmpty(target)) target = "MainMenuScreen";
            Application.LoadLevel(target);
        }
        _grid = new int[Globals.CurrentLevel.MapSize, Globals.CurrentLevel.MapSize];
        for (var i = 0; i < Globals.CurrentLevel.MapSize; i++)
        {
            for (var j = 0; j < Globals.CurrentLevel.MapSize; j++)
            {
                _grid[i, j] = Globals.CurrentLevel.MapButtons[i, j];
            }
        }

        Moves = 0;
        _dinged = false;
    }

	void Update () 
    {
        if (!_initialized) Initialize();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.PlaySFX("ButtonClick");
            Globals.LoadPreviousScreen();
        }
    }

    void Initialize()
    {
        _audioSource = GetComponent<AudioSource>();
        _greenStyle = MakeButtonStyle(Color.green);
        _redStyle = MakeButtonStyle(Color.red);
        _yellowStyle = MakeButtonStyle(Color.yellow);
        _onStyle = MakeButtonStyle(new Color(0f, 0f, 1f));
        _offStyle = MakeButtonStyle(new Color(0f, 0f, 0.5f));

        _completionShadowStyle = new GUIStyle();
        _completionShadowStyle.normal.background = Globals.MakeColorTex(new Color(0f, 0f, 0f, 0.75f));

        _completionParTextStyle = new GUIStyle();
        _completionParTextStyle.normal.textColor = Color.white;
        _completionParTextStyle.fontSize = 40;
        _completionParTextStyle.wordWrap = true;
        _completionParTextStyle.padding = new RectOffset(20, 20, 20, 20);
        _completionParTextStyle.alignment = TextAnchor.UpperCenter;

        _buttonStyle = new GUIStyle();
        _buttonStyle.normal.background = Globals.MakeColorTex(Color.blue);
        _buttonStyle.fontSize = 20;
        _buttonStyle.alignment = TextAnchor.MiddleCenter;
        _buttonStyle.normal.textColor = Color.white;

        _leftUiTextStyle = new GUIStyle();
        _leftUiTextStyle.fontSize = 25;
        _leftUiTextStyle.alignment = TextAnchor.LowerLeft;
        _leftUiTextStyle.normal.textColor = Color.white;

        _rightUiTextStyle = new GUIStyle();
        _rightUiTextStyle.fontSize = 25;
        _rightUiTextStyle.alignment = TextAnchor.LowerRight;
        _rightUiTextStyle.normal.textColor = Color.white;

        SetupLevel();
        _initialized = true;
    }

    void OnGUI()
    {
        float rx = Screen.width / Globals.NativeWidth;
        float ry = Screen.height / Globals.NativeHeight;
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(rx, ry, 1));

        if (Numlit > 0)
        {
            #region GameScreen
            var buttonSpacing = 5;
            var availableSize = 300 - ((Globals.CurrentLevel.MapSize - 1) * buttonSpacing);
            var buttonSize = availableSize / Globals.CurrentLevel.MapSize;

            for (var i = 0; i < Globals.CurrentLevel.MapSize; i++)
            {
                for (var j = 0; j < Globals.CurrentLevel.MapSize; j++)
                {
                    var btnLeft = ((i * buttonSize) + (i * buttonSpacing)) + 10;
                    var btnTop = ((j * buttonSize) + (j * buttonSpacing)) + 90;
                    GUIStyle style = _redStyle;
                    switch (_grid[i, j])
                    {
                        case GameLevel.GRN: style = _greenStyle; break;
                        case GameLevel.YLW: style = _yellowStyle; break;
                        case GameLevel.RED: style = _redStyle; break;
                        case GameLevel.LIT: style = _onStyle; break;
                        case GameLevel.OFF: style = _offStyle; break;
                    }
                    if (GUI.Button(new Rect(btnLeft, btnTop, buttonSize, buttonSize), "", style))
                    {
                        SoundManager.PlaySFX("LightButtonClick");
                        SwitchButton(i - 1, j);
                        SwitchButton(i, j - 1);
                        SwitchButton(i, j);
                        SwitchButton(i + 1, j);
                        SwitchButton(i, j + 1);
                        Moves++;
                    }
                }
            }

            GUI.Label(new Rect(10, 10, 140, 30), "Par", _leftUiTextStyle);
            GUI.Label(new Rect(10, 45, 140, 30), Globals.CurrentLevel.Par.ToString(), _leftUiTextStyle);

            GUI.Label(new Rect(170, 10, 140, 30), "Moves", _rightUiTextStyle);
            GUI.Label(new Rect(170, 45, 140, 30), Moves.ToString(), _rightUiTextStyle);

            if (GUI.Button(new Rect(10, 410, 145, 60), "Restart", _buttonStyle))
            {
                SoundManager.PlaySFX("ButtonClick");
                SetupLevel();
            }
            if (GUI.Button(new Rect(165, 410, 145, 60), "Level Select", _buttonStyle))
            {
                SoundManager.PlaySFX("ButtonClick");
                var previousScreen = Globals.PreviousScreen.Pop();
                if (!string.IsNullOrEmpty(previousScreen))
                {
                    Application.LoadLevel(previousScreen);
                }
                else
                {
                    Application.Quit();
                }
            }
            #endregion
        }
        else
        {
            #region Completion Screen
            if (!_dinged)
            {
                SoundManager.PlaySFX("Tada");
                _dinged = true;
                var previous = int.MaxValue;
                if (PlayerPrefs.HasKey(Globals.CurrentLevel.Id))
                {
                    previous = PlayerPrefs.GetInt(Globals.CurrentLevel.Id);
                }
                if(Moves < previous)
                    PlayerPrefs.SetInt(Globals.CurrentLevel.Id, Moves);
            }
            string message = "";
            if (Moves > Globals.CurrentLevel.Par)
            {
                var difference = Moves - Globals.CurrentLevel.Par;
                message = string.Format("Try again.\n\nYou went over par by\n{0}", difference);
            }
            else
            {
                var difference = Globals.CurrentLevel.Par - Moves;
                if(difference == 0)
                    message = "Great job!\n\nYou completed at par";
                else
                    message = string.Format("Awesome job!\n\nYou beat par by\n{0}", difference);
            }
            GUI.Label(new Rect(0, 0, Globals.NativeWidth, 100), message, _completionParTextStyle);
            if (GUI.Button(new Rect(10, 270, Globals.NativeWidth - 20, 60), "Replay Level", _buttonStyle))
            {
                SoundManager.PlaySFX("ButtonClick");
                SetupLevel();
            }
            if (GUI.Button(new Rect(10, 340, Globals.NativeWidth - 20, 60), "Next Level", _buttonStyle))
            {
                SoundManager.PlaySFX("ButtonClick");
                Globals.CurrentLevel = Globals.CurrentLevel.NextLevel;
                if (Globals.CurrentLevel == null)
                {
                    Application.LoadLevel("CreditsScreen");
                }
                SetupLevel();
            }
            if (GUI.Button(new Rect(10, 410, Globals.NativeWidth - 20, 60), "Level Select", _buttonStyle))
            {
                Globals.LoadPreviousScreen();
            }
            #endregion
        }
    }

    private GUIStyle MakeButtonStyle(Color color)
    {
        return new GUIStyle
        {
            border = new RectOffset(10, 10, 10, 10),
            normal = new GUIStyleState
            {
                background = Globals.MakeColorTex(color),
            }
        };

    }

    private void SwitchButton(int i, int j)
    {
        if (i < 0 || j < 0 || i >= Globals.CurrentLevel.MapSize || j >= Globals.CurrentLevel.MapSize) return;
        switch (_grid[i, j])
        {
            case GameLevel.GRN:
                _grid[i, j] = GameLevel.YLW;
                break;
            case GameLevel.YLW:
                _grid[i, j] = GameLevel.RED;
                break;
            case GameLevel.RED:
                _grid[i, j] = GameLevel.GRN;
                break;
            case GameLevel.LIT:
                _grid[i, j] = GameLevel.OFF;
                break;
            case GameLevel.OFF:
                _grid[i, j] = GameLevel.LIT;
                break;
        }
    }

    private int Numlit
    {
        get
        {
            var ct = 0;
            for (var i = 0; i < Globals.CurrentLevel.MapSize; i++)
            {
                for (var j = 0; j < Globals.CurrentLevel.MapSize; j++)
                {
                    if (_grid[i, j] == GameLevel.LIT || _grid[i, j] == GameLevel.GRN || _grid[i, j] == GameLevel.YLW) ct++;
                }
            }
            return ct;
        }
    }

    private void PlaySound(AudioClip clip)
    {
        _audioSource.clip = Instantiate(clip);
        _audioSource.Play();
    }
}
