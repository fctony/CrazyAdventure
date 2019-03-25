using UnityEngine;
using UnityEngine.Events;

public class ResetObject : MonoBehaviour
{
    public UnityEvent OnResetHandler;


    public void Reset()
    {
        OnResetHandler.Invoke();
    }

}
