using UnityEngine;
using Assets.Scripts;

public class ClassicLevelSelect : MonoBehaviour 
{
	void Start () 
    {
        Globals.Load();
	}

	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.PlaySFX("ButtonClick");
            Globals.LoadPreviousScreen();
        }
    }

    public void BackButtonPressed()
    {
        SoundManager.PlaySFX("ButtonClick");
        Globals.LoadPreviousScreen();
    }
}
