using UnityEngine;
using System.Collections;
using Assets.Scripts;
using Assets.Scripts.Levels;
using UnityEngine.SceneManagement;

public class AdvancedLevelSelect : MonoBehaviour 
{
    private bool _initialized = false;
    private GUIStyle _headerStyle;
    private GUIStyle _activeButtonStyle;
    private GUIStyle _missedButtonStyle;
    private GUIStyle _completedButtonStyle;

    private GameLevel[,] _grid = {
                                     {new Advanced11(), new Advanced21(), new Advanced31(), new Advanced41(), new Advanced51()},
                                     {new Advanced12(), new Advanced22(), new Advanced32(), new Advanced42(), new Advanced52()},
                                     {new Advanced13(), new Advanced23(), new Advanced33(), new Advanced43(), new Advanced53()},
                                     {new Advanced14(), new Advanced24(), new Advanced34(), new Advanced44(), new Advanced54()},
                                     {new Advanced15(), new Advanced25(), new Advanced35(), new Advanced45(), new Advanced55()},
                                     {new Advanced16(), new Advanced26(), new Advanced36(), new Advanced46(), new Advanced56()},
                                     {new Advanced17(), new Advanced27(), new Advanced37(), new Advanced47(), new Advanced57()}
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

        GUI.Label(new Rect(0, 0, 320, 40), "Advanced Levels", _headerStyle);
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
                    Globals.PreviousScreen.Push("AdvancedLevelSelectScreen");
                    Globals.CurrentLevel = _grid[i, j];
                    SceneManager.LoadScene("GameScreen");
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
