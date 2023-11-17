using UnityEngine;
using TMPro;

public class QuestionText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void SetText(string text)
    {
        _text.text = text;
    }
}
