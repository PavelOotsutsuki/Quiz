using UnityEngine;

public class MainMenu : Menu
{
    [SerializeField] private StartButton _startButton;
    [SerializeField] private ExitButton _exitButton;

    public void Init(ITestStarter testStarter, IGameExiter gameExiter)
    {
        _startButton.Init(testStarter);
        _exitButton.Init(gameExiter);
    }
}
