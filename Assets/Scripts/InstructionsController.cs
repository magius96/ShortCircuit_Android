using UnityEngine;
using Assets.Scripts;

public class InstructionsController : MonoBehaviour 
{
    private bool _initialized = false;
    private GUIStyle _headerStyle;
    private GUIStyle _selectedTabStyle;
    private GUIStyle _tabStyle;
    private GUIStyle _boxStyle;
    private TabState _state = TabState.Overview;

    private string _overviewText = "Short Circuit is played on a grid of lights. To play the game, you turn the lights on or off by clicking on them. " +
        "When you click on a light, the other lights near it horizontally, or vertically, will also change their state.  The objective is to turn all the lights off.";
    private string _classicText = "The classic levels use only two-phase lights.  In Short Circuit these two phase lights are all blue.  When you toggle a two phase " +
        "light, it will cycle between on and off.  Two phase lights are light blue for on, and dark blue for off.";
    private string _advancedText = "The advanced levels introduce 3 phase lights.  Three phase lights operate similiar to the way a stop light operates, but are only off when " +
        "they are red.  When you click a three phase light, green will become yellow, yellow will become red, and red will become green.  Advanced levels use both two and three phase lights.";
    private string _scoringText = "Scoring in Short Circuit is the same as in golf. Each level has a par, the minimum number of moves needed to complete the level.  If you complete a level " +
        "with more moves than par, then the level will be shown as yellow on the level select screen. If you beat the level at or below par, it will be green on the level select screen.";

    void Update()
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
        _headerStyle = new GUIStyle();
        _headerStyle.fontSize = 50;
        _headerStyle.alignment = TextAnchor.UpperCenter;
        _headerStyle.normal.textColor = Color.yellow;

        _selectedTabStyle = new GUIStyle();
        _selectedTabStyle.normal.background = Globals.MakeColorTex(Color.blue);
        _selectedTabStyle.normal.textColor = Color.white;
        _selectedTabStyle.alignment = TextAnchor.MiddleCenter;
        _selectedTabStyle.fontStyle = FontStyle.Bold;
        _selectedTabStyle.fontSize = 12;
        _selectedTabStyle.border = new RectOffset(1, 1, 1, 1);

        _tabStyle = new GUIStyle();
        _tabStyle.normal.background = Globals.MakeColorTex(new Color(0f, 0f, 0.5f));
        _tabStyle.normal.textColor = Color.gray;
        _tabStyle.alignment = TextAnchor.MiddleCenter;
        _tabStyle.fontStyle = FontStyle.Bold;
        _tabStyle.fontSize = 12;
        _tabStyle.border = new RectOffset(1, 1, 1, 1);

        _boxStyle = new GUIStyle();
        _boxStyle.wordWrap = true;
        _boxStyle.normal.background = Globals.MakeColorTex(new Color(0f, 0f, 0f, 0.75f));
        _boxStyle.normal.textColor = Color.white;
        _boxStyle.fontSize = 22;
        _boxStyle.padding = new RectOffset(10, 10, 10, 10);
    }

    void OnGUI()
    {
        float rx = Screen.width / Globals.NativeWidth;
        float ry = Screen.height / Globals.NativeHeight;
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(rx, ry, 1));

        GUI.Label(new Rect(10, 10, 300, 60), "Instructions", _headerStyle);

        if (GUI.Button(new Rect(10, 70, 70, 40), "Overview", _state == TabState.Overview ? _selectedTabStyle : _tabStyle))
        {
            SoundManager.PlaySFX("LightButtonClick");
            _state = TabState.Overview;
        }
        if (GUI.Button(new Rect(85, 70, 70, 40), "Classic", _state == TabState.Classic ? _selectedTabStyle : _tabStyle))
        {
            SoundManager.PlaySFX("LightButtonClick");
            _state = TabState.Classic;
        }
        if (GUI.Button(new Rect(160, 70, 70, 40), "Advanced", _state == TabState.Advanced ? _selectedTabStyle : _tabStyle))
        {
            SoundManager.PlaySFX("LightButtonClick");
            _state = TabState.Advanced;
        }
        if (GUI.Button(new Rect(235, 70, 70, 40), "Scoring", _state == TabState.Scoring ? _selectedTabStyle : _tabStyle))
        {
            SoundManager.PlaySFX("LightButtonClick");
            _state = TabState.Scoring;
        }

        var boxText = "";
        switch(_state)
        {
            case TabState.Overview: boxText = _overviewText; break;
            case TabState.Classic: boxText = _classicText; break;
            case TabState.Advanced: boxText = _advancedText; break;
            case TabState.Scoring: boxText = _scoringText; break;
        }
        GUI.Box(new Rect(10, 110, 300, 360), boxText, _boxStyle);
    }

    enum TabState
    {
        Overview,
        Classic,
        Advanced,
        Scoring
    }
}
