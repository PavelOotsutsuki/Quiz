using UnityEngine;

public abstract class Menu : MonoBehaviour
{
    public virtual void Activate()
    {
        gameObject.SetActive(true);
    }

    public virtual void Disactivate()
    {
        gameObject.SetActive(false);
    }
}
