using UnityEngine;
using UnityEngine.EventSystems;

public class ExitButton : MonoBehaviour, IPointerClickHandler
{
    private IGameExiter _gameExiter;

    public void Init(IGameExiter gameExiter)
    {
        _gameExiter = gameExiter;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _gameExiter.ExitGame();
    }
}
