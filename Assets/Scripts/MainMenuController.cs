using UnityEngine;
using Assets.Scripts;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
    private bool _initialized = false;
    private GUIStyle _headerStyle;
    private GUIStyle _buttonStyle;

	void Update ()
    {
        if (!_initialized) Initialize();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.PlaySFX("ButtonClick");
            Globals.LoadPreviousScreen(true);
        }
    }

    private void Initialize()
    {
        Globals.Load();
        _headerStyle = new GUIStyle();
        _headerStyle.fontSize = 50;
        _headerStyle.alignment = TextAnchor.UpperCenter;
        _headerStyle.normal.textColor = Color.yellow;

        _buttonStyle = new GUIStyle();
        _buttonStyle.normal.background = Globals.MakeColorTex(Color.blue);
        _buttonStyle.fontSize = 22;
        _buttonStyle.normal.textColor = Color.white;
        _buttonStyle.fontStyle = FontStyle.Bold;
        _buttonStyle.alignment = TextAnchor.MiddleCenter;
    }

    void OnGUI()
    {
        float rx = Screen.width / Globals.NativeWidth;
        float ry = Screen.height / Globals.NativeHeight;
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(rx, ry, 1));

        float buttonSpacing = 5f;
        float left = 10f;
        float buttonWidth = 300f;

        float pos = 85;
        float avail = 470 - pos;
        float numButtons = 7;
        float availPer = avail/numButtons;
        float buttonSize = availPer - buttonSpacing;

        GUI.Label(new Rect(left, 10, buttonWidth, buttonSize), "Short Circuit", _headerStyle);
        if (GUI.Button(new Rect(left, pos, buttonWidth, buttonSize), "Classic Levels", _buttonStyle))
        {
            Globals.PreviousScreen.Push("MainMenuScreen");
            SceneManager.LoadScene("ClassicLevelSelectScreen");
        }
        pos += buttonSize + buttonSpacing;
        if (GUI.Button(new Rect(left, pos, buttonWidth, buttonSize), "Advanced Levels", _buttonStyle))
        {
            Globals.PreviousScreen.Push("MainMenuScreen");
            SceneManager.LoadScene("AdvancedLevelSelectScreen");
        }
        pos += buttonSize + buttonSpacing;
        if (GUI.Button(new Rect(left, pos, buttonWidth, buttonSize), "Infinite Levels", _buttonStyle))
        {
            Globals.PreviousScreen.Push("MainMenuScreen");
            SceneManager.LoadScene("InfiniteLevelSetupScreen");
        }
        pos += buttonSize + buttonSpacing;
        if (GUI.Button(new Rect(left, pos, buttonWidth, buttonSize), "Instructions", _buttonStyle))
        {
            Globals.PreviousScreen.Push("MainMenuScreen");
            SceneManager.LoadScene("InstructionScreen");
        }
        pos += buttonSize + buttonSpacing;
        if (GUI.Button(new Rect(left, pos, buttonWidth, buttonSize), "Options", _buttonStyle))
        {
            Globals.PreviousScreen.Push("MainMenuScreen");
            SceneManager.LoadScene("OptionsScreen");
        }
        pos += buttonSize + buttonSpacing;
        if (GUI.Button(new Rect(left, pos, buttonWidth, buttonSize), "Credits", _buttonStyle))
        {
            Globals.PreviousScreen.Push("MainMenuScreen");
            SceneManager.LoadScene("CreditsScreen");
        }
        pos += buttonSize + buttonSpacing;
        if (GUI.Button(new Rect(left, pos, buttonWidth, buttonSize), "Quit", _buttonStyle))
        {
            Globals.PreviousScreen.Push("MainMenuScreen");
            Application.Quit();
        }
    }
}
