using System.Collections.Generic;
using Assets.Scripts.Levels;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public static class Globals
    {
        public static float NativeWidth = 320f;
        public static float NativeHeight = 480f;

        public static GameLevel CurrentLevel = new Advanced11();
        public static Stack<string> PreviousScreen = new Stack<string>();

        public static void LoadPreviousScreen(bool orQuit = false)
        {
            string previousScreen = "";
            if (PreviousScreen.Count > 0)
                previousScreen = Globals.PreviousScreen.Pop();
            if (!string.IsNullOrEmpty(previousScreen))
            {
                SceneManager.LoadScene(previousScreen);
            }
            else
            {
                if (orQuit)
                    Application.Quit();
                else
                    SceneManager.LoadScene("MainMenuScreen");
            }
        }

        private static bool _dataLoaded = false;

        private static float _musicVolume = 1f;
        public static float MusicVolume
        {
            get
            {
                if (!_dataLoaded) Load();
                return _musicVolume;
            }
            set
            {
                _musicVolume = value;
                SoundManager.SetVolumeMusic(value);
                Save();
            }
        }

        private static float _soundVolume = 1f;
        public static float SoundVolume
        {
            get
            {
                if (!_dataLoaded) Load();
                return _soundVolume;
            }
            set
            {
                _soundVolume = value;
                SoundManager.SetVolumeSFX(value);
                Save();
            }
        }

        public static void Load()
        {
            if (PlayerPrefs.HasKey("MusicVolume"))
                _musicVolume = PlayerPrefs.GetFloat("MusicVolume");
            else _musicVolume = 0.5f;
            SoundManager.SetVolumeMusic(_musicVolume);

            if (PlayerPrefs.HasKey("SoundVolume"))
                _soundVolume = PlayerPrefs.GetFloat("SoundVolume");
            else _soundVolume = 1f;
            SoundManager.SetVolumeSFX(_soundVolume);
        }

        public static void Save()
        {
            PlayerPrefs.SetFloat("MusicVolume", _musicVolume);
            PlayerPrefs.SetFloat("SoundVolume", _soundVolume);
        }

        public static Texture2D MakeColorTex(Color col)
        {
            Color[] pix = new Color[1];
            pix[0] = col;
            Texture2D result = new Texture2D(1, 1);
            result.SetPixels(pix);
            result.Apply();
            return result;
        }
        public static Texture2D MakeColorTex(Color col, int width, int height)
        {
            Color[] pix = new Color[width * height];
            for (var j = 0; j < height; j++)
            {
                for (var i = 0; i < width; i++)
                {
                    pix[i*j] = col;
                }
            }
            Texture2D result = new Texture2D(width, height);
            result.SetPixels(pix);
            result.Apply();
            return result;
        }


        public static bool InfiniteLevelUses3Phase = true;
        public static int InfiniteLevelGridSize = 6;
        public static int InfiniteLevelMoves = 5;
    }
}
