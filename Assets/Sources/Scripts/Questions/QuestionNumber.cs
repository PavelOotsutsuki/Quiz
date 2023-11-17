using UnityEngine;
using TMPro;

public class QuestionNumber : MonoBehaviour
{
    private const string DefaultText = "Вопрос ";

    [SerializeField] private TMP_Text _number;

    public void SetNumber(string number)
    {
        _number.text = DefaultText + number;
    }

}
