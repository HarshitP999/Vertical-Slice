using UnityEngine;

public interface IVisibilityAware 
{
    Vector3 pos { get; }
    void IVisibilityChange(bool visible);

}
