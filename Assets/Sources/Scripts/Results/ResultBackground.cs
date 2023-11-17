using UnityEngine;
using UnityEngine.UI;

public class ResultBackground : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _trueColor;
    [SerializeField] private Color _falseColor;

    public void SetMode(bool isCorrect)
    {
        Color color;

        if (isCorrect)
        {
            color = _trueColor;
        }
        else
        {
            color = _falseColor;
        }

        _image.color = color;
    }
}
