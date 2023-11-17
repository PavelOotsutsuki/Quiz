using UnityEngine;
using UnityEngine.EventSystems;

public class NewGameButton : MonoBehaviour, IPointerClickHandler
{
    private IGameStarter _gameStarter;

    public void Init(IGameStarter gameStarter)
    {
        _gameStarter = gameStarter;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _gameStarter.StartMainMenu();
    }
}
