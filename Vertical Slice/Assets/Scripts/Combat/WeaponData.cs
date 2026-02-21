using UnityEngine;


    [CreateAssetMenu(fileName = "NewWeaponData", menuName = "ScriptableObject/WeaponData", order = 1)]
    public class WeaponData : ScriptableObject
    {
        [Header("Stats")]
        [Min(0)] public float maxDamage;
        [Min(0)] public int maxAmmo;


        public enum DamageType { Gun, Knife, Throwable }
    }

