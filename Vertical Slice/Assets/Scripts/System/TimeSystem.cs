using System;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    public float startTime = 30f;

    float timeRemaining;

    public event Action OnTimeExpired;



    void OnEnable()
    {
        timeRemaining = startTime;
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            timeRemaining = 0f;
            OnTimeExpired?.Invoke();

            enabled = false;
        }
    }


    public float GetNormalizedTime()
    {
        return timeRemaining / startTime;
    }
}
