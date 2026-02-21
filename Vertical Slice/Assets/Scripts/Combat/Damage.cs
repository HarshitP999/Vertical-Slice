using UnityEngine;
using static WeaponData;

public class Damage : MonoBehaviour
{
    public readonly int amount;
    public readonly DamageType type;
    public readonly Vector3 force;

    public Damage(DamageType type, int amount, Vector3 force)
    {
        this.type = type;
        this.amount = amount;
        this.force = force;
    }
}

