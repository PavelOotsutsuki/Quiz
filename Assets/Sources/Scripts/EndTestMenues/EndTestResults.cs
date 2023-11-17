using UnityEngine;
using TMPro;

public class EndTestResults : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void SetResults(int takenPoints, int maxPoints)
    {
        _text.text = takenPoints.ToString() + "/" + maxPoints.ToString();
    }
}
