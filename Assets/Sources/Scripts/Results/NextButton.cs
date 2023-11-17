using UnityEngine;
using UnityEngine.EventSystems;

public class NextButton : MonoBehaviour, IPointerClickHandler
{
    private ITestContinuer _testContinuer;

    public void Init(ITestContinuer testContinuer)
    {
        _testContinuer = testContinuer;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _testContinuer.ContinueTest();
    }
}
