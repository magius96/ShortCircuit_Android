using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundPulse : MonoBehaviour 
{
    public float PulseChangeAmount = 0.001f;
    public float TopPulsevalue = 0.8f;
    public float BottomPulseValue = 0.3f;
    public bool Pulse = true;

    private float _pulseValue = 0.5f;
    private bool _goingUp = true;
    private Image _image;

    void Update () 
    {
        if (!Pulse) return;
        if (_image == null)
        {
            _image = transform.GetComponent<Image>();
        }
        if (_goingUp)
        {
            _pulseValue += PulseChangeAmount;
        }
        else
        {
            _pulseValue -= PulseChangeAmount;
        }

        if (_goingUp && _pulseValue >= TopPulsevalue)
        {
            _goingUp = false;
        }

        if (!_goingUp && _pulseValue <= BottomPulseValue)
        {
            _goingUp = true;
        }

        _image.color = new Color(_pulseValue, _pulseValue, _pulseValue);
	}
}
