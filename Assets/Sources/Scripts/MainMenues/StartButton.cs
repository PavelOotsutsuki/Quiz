using UnityEngine;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour, IPointerClickHandler
{
    private ITestStarter _testStarter;

    public void Init(ITestStarter testStarter)
    {
        _testStarter = testStarter;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _testStarter.StartTest();
    }
}
