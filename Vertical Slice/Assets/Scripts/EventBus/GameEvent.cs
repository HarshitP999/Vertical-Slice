using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    List<GameEventListener> Listners = new List<GameEventListener>();


    public void Raise()
    {
        for (int i = 0; i < Listners.Count; i++)
        {
            Listners[i].OnEventRaise();

        }
    }
    public void Registered(GameEventListener listner)
    {
        if (!Listners.Contains(listner))
        {
            Listners.Add(listner);
        }
    }
    public void UnRegistered(GameEventListener listener)
    {
        if (Listners.Contains(listener))
        {
            Listners.Remove(listener);
        }
    }
}
