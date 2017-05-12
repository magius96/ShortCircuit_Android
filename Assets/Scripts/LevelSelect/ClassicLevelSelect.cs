using UnityEngine;
using System.Collections;
using Assets.Scripts;
using Assets.Scripts.Levels;

public class ClassicLevelSelect : MonoBehaviour 
{
    private bool _initialized = false;
    private GUIStyle _headerStyle;
    private GUIStyle _activeButtonStyle;
    private GUIStyle _missedButtonStyle;
    private GUIStyle _completedButtonStyle;

    private GameLevel[,] _grid = {
                                     {new Classic11(), new Classic21(), new Classic31(), new Classic41(), new Classic51()},
                                     {new Classic12(), new Classic22(), new Classic32(), new Classic42(), new Classic52()},
                                     {new Classic13(), new Classic23(), new Classic33(), new Classic43(), new Classic53()},
                                     {new Classic14(), new Classic24(), new Classic34(), new Classic44(), new Classic54()},
                                     {new Classic15(), new Classic25(), new Classic35(), new Classic45(), new Classic55()},
                                     {new Classic16(), new Classic26(), new Classic36(), new Classic46(), new Classic56()},
                                     {new Classic17(), new Classic27(), new Classic37(), new Classic47(), new Classic57()}
                                 };
	void Start () 
    {
        Globals.Load();
	}

    private void Initialize()
    {
        _headerStyle = new GUIStyle();
        _headerStyle.fontSize = 30;
        _headerStyle.fontStyle = FontStyle.Bold;
        _headerStyle.normal.textColor = new Color(1f, 1f, 0f);
        _headerStyle.alignment = TextAnchor.LowerCenter;

        _activeButtonStyle = SetupButtonStyle(Color.blue);
        _missedButtonStyle = SetupButtonStyle(Color.yellow);
        _completedButtonStyle = SetupButtonStyle(Color.green);
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

	void Update () 
    {
        if (!_initialized) Initialize();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.PlaySFX("ButtonClick");
            Globals.LoadPreviousScreen();
        }
    }

    void OnGUI()
    {
        float rx = Screen.width / Globals.NativeWidth;
        float ry = Screen.height / Globals.NativeHeight;
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(rx, ry, 1));

        GUI.Label(new Rect(0, 0, 320, 40), "Classic Levels", _headerStyle);
        for (var i = 0; i < 7; i++)
        {
            for (var j = 0; j < 5; j++)
            {
                var lvl = _grid[i, j];
                GUIStyle style = GetStyle(lvl);
                    
                var txt = string.Format("{0}-{1}", j + 1, i + 1);
                if (GUI.Button(new Rect((j * 60) + 10, (i * 60) + 50, 55, 55), txt, style))
                {
                    SoundManager.PlaySFX("ButtonClick");
                    Globals.PreviousScreen.Push("ClassicLevelSelectScreen");
                    Globals.CurrentLevel = _grid[i, j];
                    Application.LoadLevel("GameScreen");
                }
            }
        }
    }

    private GUIStyle GetStyle(GameLevel lvl)
    {
        if (PlayerPrefs.HasKey(lvl.Id))
        {
            var moves = PlayerPrefs.GetInt(lvl.Id);
            if (moves <= lvl.Par)
            {
                return _completedButtonStyle;
            }
            else
            {
                return _missedButtonStyle;
            }
        }
        else
            return _activeButtonStyle;
    }
}
