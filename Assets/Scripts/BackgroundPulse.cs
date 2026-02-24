using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundPulse : MonoBehaviour 
{
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
            _pulseValue += GameConstants.BackgroundPusleChangeAmount;
        }
        else
        {
            _pulseValue -= GameConstants.BackgroundPusleChangeAmount;
        }

        if (_goingUp && _pulseValue >= GameConstants.BackgroundPulseTopValue)
        {
            _goingUp = false;
        }

        if (!_goingUp && _pulseValue <= GameConstants.BackgroundPulseBottomValue)
        {
            _goingUp = true;
        }

        _image.color = new Color(_pulseValue, _pulseValue, _pulseValue);
	}
}
