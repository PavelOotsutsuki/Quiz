using System;
using UnityEngine;

public class GameRoot : MonoBehaviour, ITestStarter, IGameExiter, IGameStarter, IResultDisplayer, ITestContinuer, ITestFinisher
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private Question _question;
    [SerializeField] private Result _result;
    [SerializeField] private EndTestMenu _endTestMenu;

    private Menu[] _allMenues;
    private TestFile _testFile;

    private void Start()
    {
        FillMenues();
        InitAll();
        StartMainMenu();
    }

    public void StartTest()
    {
        _endTestMenu.StartTest(_testFile.GetCountRounds());
        ActivateMenu(_question);
    }

    public void ContinueTest()
    {
        ActivateMenu(_question);
    }

    public void FinishTest()
    {
        ActivateMenu(_endTestMenu);
    }

    public void ShowResult(bool isCorrect)
    {
        if (isCorrect)
        {
            _endTestMenu.AddPoint();
        }

        _result.SetMode(isCorrect);
        ActivateMenu(_result);
    }

    public void StartMainMenu()
    {
        ActivateMenu(_mainMenu);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private void InitAll()
    {
        _testFile = new TestFile();
        _mainMenu.Init(this, this);
        _question.Init(_testFile, this, this);
        _result.Init(this);
        _endTestMenu.Init(this);
    }

    private void FillMenues()
    {
        _allMenues = new Menu[4];

        _allMenues[0] = _mainMenu;
        _allMenues[1] = _question;
        _allMenues[2] = _result;
        _allMenues[3] = _endTestMenu;
    }

    private void DisacivateAllMenues()
    {
        foreach (Menu menu in _allMenues)
        {
            menu.Disactivate();
        }
    }

    private void ActivateMenu(Menu activatedMenu)
    {
        DisacivateAllMenues();

        activatedMenu.Activate();
    }
}
