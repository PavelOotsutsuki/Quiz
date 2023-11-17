using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Answer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TMP_Text _textField;

    private bool _isCorrect;
    private IResultDisplayer _resultDisplayer;

    //public TMP_Text TextField => _textField;

    public void Init(IResultDisplayer resultDisplayer)
    {
        _resultDisplayer = resultDisplayer;
    }

    public void SetData(string text, bool isCorrect)
    {
        _textField.text = text;
        _isCorrect = isCorrect;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _resultDisplayer.ShowResult(_isCorrect);
    }
}
