using UnityEngine;
using Assets.Scripts;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Slider MusicSlider;
    public Slider SoundSlider;

	void Start ()
    {
        Globals.Load();
        MusicSlider.value = Globals.MusicVolume;
        SoundSlider.value = Globals.SoundVolume;
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

    public void MusicSliderChanged()
    {
        Globals.MusicVolume = MusicSlider.value;
    }

    public void SoundSliderChanged()
    {
        Globals.SoundVolume = SoundSlider.value;
        SoundManager.PlaySFX("ding");
    }
}
