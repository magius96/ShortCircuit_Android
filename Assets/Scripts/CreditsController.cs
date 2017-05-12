using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class CreditsController : MonoBehaviour 
{
    private bool _initialized = false;
    private GUIStyle _headerStyle;
    private GUIStyle _textStyle;
    private string _credits = "";

	void Start () 
    {
        _credits = "Created By: Jason Yarber\n" +
            "\n" +
            "Development Adviser: Jessica Yarber\n" +
            "\n" +
            "Playtesting: Jason Yarber\n" +
            "             Jessica Yarber\n" +
            "             Jesse Glover\n" +
            "\n" +
            "Game Music: Matt McFarland\n" +
            "     www.mattmcfarland.com\n" +
            "          crushedout, Conspiracy, down\n" +
            "          findingHappiness, Kreepor, rock out\n" +
            "\n" +
            "Powered by: Unity3d\n" +
            "\n" +
            "Game design based upon: Lights Out Handheld\n" +
            "By Tiger Electronics Ltd.\n" +
            "\n" +
            "In memory of Betty Lou Yarber\n" +
            "She always believed in me.\n" +
            "\n" +
            "Send questions and comments to:\n" +
            "     JasonYarber@hotmail.com\n" +
            "\n" +
            "Thank you for playing.";
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

    private void Initialize()
    {
        _headerStyle = new GUIStyle();
        _headerStyle.fontSize = 40;
        _headerStyle.alignment = TextAnchor.UpperCenter;
        _headerStyle.normal.textColor = Color.yellow;

        _textStyle = new GUIStyle();
        _textStyle.normal.textColor = Color.white;
    }

    void OnGUI()
    {
        float rx = Screen.width / Globals.NativeWidth;
        float ry = Screen.height / Globals.NativeHeight;
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(rx, ry, 1));

        GUI.Label(new Rect(10, 10, 300, 60), "Short Circuit", _headerStyle);

        GUI.Box(new Rect(10, 80, 300, 390), _credits, _textStyle);

    }
}
