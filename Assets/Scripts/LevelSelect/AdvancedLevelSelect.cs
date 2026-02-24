using UnityEngine;
using Assets.Scripts;

public class AdvancedLevelSelect : MonoBehaviour 
{
    void Start()
    {
        Globals.Load();
    }

    void Update()
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