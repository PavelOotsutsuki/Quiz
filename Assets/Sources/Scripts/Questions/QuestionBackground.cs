using UnityEngine;
using UnityEngine.UI;

public class QuestionBackground : MonoBehaviour
{
    [SerializeField] private Image _image;

    public void SetImage(Sprite sprite)
    {
        _image.sprite = sprite;
    }
}
