using UnityEngine;

public class Question : Menu
{
    [SerializeField] private QuestionBackground _questionBackground;
    [SerializeField] private QuestionNumber _questionNumber;
    [SerializeField] private QuestionText _questionText;
    [SerializeField] private AnswerRoot _answerRoot;

    private TestFile _testFile;
    private int _lastQuestionNumber;
    private ITestFinisher _testFinisher;

    public void Init(TestFile testFile, IResultDisplayer resultDisplayer, ITestFinisher testFinisher)
    {
        _testFile = testFile;
        _testFinisher = testFinisher;
        _answerRoot.Init(resultDisplayer);
        Reset();
    }

    public override void Activate()
    {
        base.Activate();

        _lastQuestionNumber++;

        if (_lastQuestionNumber >= _testFile.GetCountRounds())
        {
            Reset();
            _testFinisher.FinishTest();
            return;
        }

        LoadQuestionData();
    }

    private void Reset()
    {
        _lastQuestionNumber = -1;
    }

    private void LoadQuestionData()
    {
        if(_testFile.TryGetRoundData(_lastQuestionNumber, out string questionText, out JsonAnswer[] answers, out Sprite background) == false)
        {
            Debug.LogError("Error count questions");
            return;
        }

        int questionNumber = _lastQuestionNumber + 1;

        _questionNumber.SetNumber(questionNumber.ToString());
        _questionText.SetText(questionText);
        _answerRoot.FillAnswers(answers);
        _questionBackground.SetImage(background);
    }
}
