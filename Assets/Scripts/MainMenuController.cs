using UnityEngine;
using Assets.Scripts;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
    private bool _initialized = false;

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
    }
}