using UnityEngine;

public class Result : Menu
{
    [SerializeField] private ResultBackground _resultBackground;
    [SerializeField] private AnswerResultLabel _answerResultLabel;
    [SerializeField] private NextButton _nextButton;

    private bool _isCorrectMode;

    public void Init(ITestContinuer testContinuer)
    {
        _nextButton.Init(testContinuer);
    }

    public void SetMode(bool mode)
    {
        _isCorrectMode = mode;
    }

    public override void Activate()
    {
        base.Activate();

        _resultBackground.SetMode(_isCorrectMode);
        _answerResultLabel.SetMode(_isCorrectMode);
    }
}
