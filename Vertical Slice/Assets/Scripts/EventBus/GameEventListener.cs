using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;

    public UnityEvent Response;

    private void OnEnable()
    {
        Event.Registered(this);
    }

    private void OnDisable()
    {
        Event.UnRegistered(this);
    }
    public void OnEventRaise()
    {
        Response.Invoke();
    }
}
