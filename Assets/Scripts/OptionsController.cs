using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class OptionsController : MonoBehaviour
{
    public float MusicVolumeTop = 195;
    public float SoundVolumeTop = 285;
    private bool _initialized = false;
    private GUIStyle _headerStyle;
    private GUIStyle _backBoxStyle;

	void Start ()
    {
	    
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
        _headerStyle.fontSize = 50;
        _headerStyle.alignment = TextAnchor.UpperCenter;
        _headerStyle.normal.textColor = Color.yellow;

        _backBoxStyle = new GUIStyle();
        _backBoxStyle.normal.background = Globals.MakeColorTex(Color.blue);
        _backBoxStyle.normal.textColor = Color.white;
        _backBoxStyle.alignment = TextAnchor.UpperCenter;
        _backBoxStyle.fontSize = 22;
    }

    void OnGUI()
    {
        float rx = Screen.width / Globals.NativeWidth;
        float ry = Screen.height / Globals.NativeHeight;
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(rx, ry, 1));

        GUI.Label(new Rect(10, 10, 300, 60), "Options", _headerStyle);

        GUI.Box(new Rect(10, 185, 300, 40), "Music Volume", _backBoxStyle);
        Globals.MusicVolume = GUI.HorizontalSlider(new Rect(15, 210, 290, 20), Globals.MusicVolume, 0, .25f);

        GUI.Box(new Rect(10, 250, 300, 40), "Sound Volume", _backBoxStyle);
        float val = GUI.HorizontalSlider(new Rect(15, 275, 290, 20), Globals.SoundVolume, 0, 1);
        if(val != Globals.SoundVolume)
        {
            Globals.SoundVolume = val;
            SoundManager.PlaySFX("ding");
        }
    }
}
