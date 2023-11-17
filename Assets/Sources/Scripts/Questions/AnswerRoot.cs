using UnityEngine;

public class AnswerRoot : MonoBehaviour
{
    [SerializeField] private Answer[] _answers;

    public void Init(IResultDisplayer resultDisplayer)
    {
        foreach (Answer answer in _answers)
        {
            answer.Init(resultDisplayer);
        }
    }

    public void FillAnswers(JsonAnswer[] answers)
    {
        if (answers.Length != _answers.Length)
        {
            Debug.LogError("Error count data for answers and answers");
            return;
        }

        string text;
        bool isCorrect;

        for(int i = 0; i < _answers.Length; i++)
        {
            text = answers[i].text;
            isCorrect = answers[i].correct;

            _answers[i].SetData(text, isCorrect);
        }
    }
}
