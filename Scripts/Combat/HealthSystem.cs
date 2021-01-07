using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

  public class HealthSystem : MonoBehaviour
    {
        [SerializeField] private int health = 100;

        public event Action<int> OnHealthChanged;
        public static event Action OnPlayerLose;

        public int Health => health;

        private void OnEnable() => WaveDestination.OnEnemyReachedEnd += HandleEnemyReachedEnd;
        private void OnDisable() => WaveDestination.OnEnemyReachedEnd -= HandleEnemyReachedEnd;

        private void HandleEnemyReachedEnd(EnemyData enemyData)
        {
            health = Mathf.Max(health - enemyData.Damage);

            OnHealthChanged?.Invoke(health);

            if (health != 0) { return; }

            OnPlayerLose?.Invoke();
        }
    }
