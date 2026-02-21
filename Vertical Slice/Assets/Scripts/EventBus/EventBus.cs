using System;
using UnityEngine;

public interface IEvent { }

internal interface IEventBinding<T> 
{
 public Action<T>  OnEvent {get; set;}
 public T InEventNoArgs {get; set;}


}



