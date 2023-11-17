using UnityEngine;
using TMPro;

public class AnswerResultLabel : MonoBehaviour
{
    private const string TrueLabel = "Верно!";
    private const string FalseLabel = "Неверно!";

    [SerializeField] private TMP_Text _text;

    public void SetMode(bool isCorrect)
    {
        string label;

        if (isCorrect)
        {
            label = TrueLabel;
        }
        else
        {
            label = FalseLabel;
        }

        _text.text = label;
    }
}
