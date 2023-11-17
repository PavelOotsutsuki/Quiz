using UnityEngine;

public class EndTestMenu : Menu
{
    [SerializeField] private EndTestResults _endTestResults;
    [SerializeField] private NewGameButton _newGameButton;

    private int _takenPoints;
    private int _maxPoints;

    public void Init(IGameStarter gameStarter)
    {
        _newGameButton.Init(gameStarter);
    }

    public void StartTest(int maxPoints)
    {
        _maxPoints = maxPoints;
        _takenPoints = 0;
    }

    public void AddPoint()
    {
        _takenPoints++;
    }

    public override void Activate()
    {
        base.Activate();

        _endTestResults.SetResults(_takenPoints, _maxPoints);
    }
}
