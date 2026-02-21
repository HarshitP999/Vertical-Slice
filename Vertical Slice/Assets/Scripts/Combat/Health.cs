using System;
using UnityEngine;

public class Health : MonoBehaviour, IDamageable
{
   
        int currentHealth;
        int maxHp = 100;

        public event Action<int> OnDeath;
        public event Action OnHealth;
        private void Awake() => currentHealth = maxHp;

        public void ReceiveDamage(Damage dmg, GameObject attacker)
        {

            currentHealth -= dmg.amount;

            OnDeath.Invoke(currentHealth);

            if (currentHealth <= 0) Die();
        }

        void Die()
        {
            OnDeath?.Invoke(currentHealth);
            Destroy(gameObject);
        }



    
}
