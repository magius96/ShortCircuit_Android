using UnityEngine;
using Assets.Scripts;

public class CreditsController : MonoBehaviour 
{
	void Start () 
    {
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
